#include <16f877a.h>                                                              // Kullanilacak denetleyicinin baslikk dosyasi tanitiliyor.
#device ADC=10                                                                   //2^10 yani 1024 çözünürlükde adc tanimlandi
#fuses XT,NOWDT,NOPROTECT,NOBROWNOUT,NOLVP,NOPUT,NOWRT,NODEBUG,NOCPD             // Denetleyici konfigürasyon ayarlari
#use delay (clock=4000000)                                                       // Gecikme fonksiyonu için kullanilacak osilatör frekansi belirtiliyor.
#include <crc.c>                                                                 // CRC kütüphanesi eklendi
#include <LCD.c>                                                                 // LCD kutuphanesi eklendi
// #include <input.c>
#use fast_io(d)                                                                  // D portu LCD için tanimlandi
#use rs232 (baud=9600, xmit=pin_C6, rcv=pin_C7, parity=N, stop=1,timeout=10)    // RS232 protokol ayarlar
// #use i2c(master,sda=pin_c4,scl=pin_c3,slow=100000)



#define   CRCKEY     0xd5                                                              
#define   ACK        0x00
#define   rx_pin     pin_C1
#define   hata_pin   pin_C2
#define   send_pin   pin_C0

int       gett[40];
int       CRC,hata,analog_intt,bb;
float     analogg=0;
float     voltt=0;
float     heatt;
float     xx=10;

#int_ssp
void i2c_int()
{
   
}
#int_RDA
void seri()
{
            
            output_high(rx_pin); //receive  
            hata=false;
            gett[0]=getc(); // gönderen 
            gett[1]=getc(); // alan 
            gett[2]=getc(); // ack 
            gett[3]=getc(); // data length
            gett[4]=getc(); // data
            CRC=getc();    // crc   
            bb=generate_8bit_crc(gett,40,CRCKEY);
            output_low(rx_pin);
            output_high(send_pin); 
            
            

            
           
}
 
void oku_yaz()
{     
      analogg =read_adc()*0.489;
      delay_us(40);
      heatt=analogg ;    //sicaklik verimiz
      printf(lcd_putc,"\f istenen=%f C \n SICAKLIK=%2.1f C ",xx,heatt); // gerilim degerini yazdirdik
      analog_intt=heatt;     
}

void send_gui()
{     
      output_low(pin_c5);
      delay_ms(5);

      output_high(send_pin);
      putc('G');
      putc('2');
      putc(analog_intt);
      delay_ms(5);
      output_low(send_pin);
      output_high(pin_c5);
      clear_interrupt(int_tbe);
}

void sogutucu()
{
     if(xx<=heatt)
     {     
         output_high(pin_c3); 
     }
     else
     {   
        output_low(pin_c3);
     }
}

void karar()

{
output_high(send_pin); 
                  if(gett[0]==0x11)  //gonderen adresi
                  {
               
                           if(gett[1] == 0x31) // alici adresi
                           {

                                    
                                       if(bb==CRC)
                                       {  
                                        
                                          
                                          xx=gett[4];
                                          output_b(gett[4]);
                                          output_low(hata_pin);
                                                                                      
                                       }
                                       else
                                       {
                                          hata=true;
                                          output_high(hata_pin);                          
                                       }             
                           }    
                  }     
     
     output_low(send_pin);
     clear_interrupt(int_tbe);
}

void send_ack()
{
    if(gett[2]==0x01)
    {
      output_high(send_pin);
      putc('M');
      putc('2');
      putc(0x00);
      gett[2]=0x00;
      output_low(send_pin);
      clear_interrupt(int_tbe);
      
    }
}

void main ( )
{  
   output_low(send_pin);
   output_low(send_pin);
   enable_interrupts(GLOBAL);
   enable_interrupts(INT_RDA);
   clear_interrupt(int_tbe);
   clear_interrupt(INT_RDA);
       
   output_b(0x00);   
   setup_adc(ADC_CLOCK_DIV_32);     // Set ADC conversion time to 32Tosc
   setup_adc_ports(AN0);            // Configure AN0 as analog
   set_adc_channel(0);              //adc kanal, ayarlandi
   delay_us(30);                    //analog güvenlik için
   lcd_init();


   while(!interrupt_active(int_rda)) //rda kesmesi aktif degilse, veri gönderebilecek durumdaysak...

   { 
      output_b(bb);
      delay_ms(300);
     oku_yaz();
     sogutucu();
     send_ack();
     send_gui();
     karar();
     delay_ms(770);
     
   } 

   
}

   
   

 
  

