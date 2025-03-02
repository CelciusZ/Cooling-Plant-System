#include <16f877A.h>     // Kullan�lacak denetleyicinin ba�l�k dosyas� tan�t�l�yor.
// Denetleyici konfig�rasyon ayarlar�
#fuses XT,NOWDT,NOPROTECT,NOBROWNOUT,NOLVP,NOPUT,NOWRT,NODEBUG,NOCPD
#use delay (clock=4000000) // Gecikme fonksiyonu i�in kullan�lacak osilat�r frekans� belirtiliyor.
#use rs232 (baud=9600, xmit=pin_C6, rcv=pin_C7, parity=N, stop=1,timeout=100) // RS232 protokol�n�n 9600 bit/sn baud h�z�nda olaca��n� ve
// TX,RX u�lar�n�n hangi pinler olaca��n� tan�ml�yor            // parity bitinin olmad���n�, stop bitinin 1 bit olaca�� belirtiliyor
#include <crc.c>
int get[24];
int CRC;

#define send_pin pin_C0
#define rx_pin pin_C1
#define ack_pin pin_C2



#int_RDA 
void seri()
{  
   output_high(rx_pin);
   get[0]=getc(); // g�nderen 
   get[1]=getc(); // alan 
   get[2]=getc(); // ack 
   
   if(get[0]==0x4d)
   {
            output_high(ack_pin); // ack ledini yak
      
    
      if(get[1] ==0x31 || get[1] ==0x21 || get[1] ==0x41)
      {
         
         if(get[2]==0x00)
         {  


         }
         else
         {
            output_b(get[2]);         
         }
      }

   }
  delay_ms(200);
  output_low(rx_pin);
  output_low(ack_pin);
  


}




void make_packet(char slave_adress, char data)
{
   output_high(send_pin);
   delay_ms(5);
   get[0]=0x11; // MASTER ADRESS
   get[1]=slave_adress; // SLAVE1 ADRESS
   get[2]=0x01; // ACK istiyor mu ?
   get[3]=0x01; // DATA LENGTH
   get[4]=data; // DATA
   CRC=generate_8bit_crc(get,40,0xd5);
   output_b(CRC);
   
   for(int i = 0;i<5;i++)
   {
   putc(get[i]);
   }
   
   putc(CRC);
   delay_ms(50);
   output_low(send_pin);
   clear_interrupt(INT_TBE);
   // 6 byte g�nderildi.
}


void main ( )
{
   output_low(send_pin);
   enable_interrupts(GLOBAL);
   clear_interrupt(INT_RDA);
   enable_interrupts(INT_RDA);
   clear_interrupt(int_tbe);
//!   
   
   
   for(int i=0;i<255;i++)
   {
   make_packet(0x21,i);
   delay_ms(3000); 
   }
 
   
}   

