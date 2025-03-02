# GUI ile Soğutma Tesisi Sıcaklık Kontrolü

**Ad Soyad:** Enez Aykut GÜLIRMAK  

Bu proje, bir soğutma tesisinin sıcaklık kontrolünü sağlayan bir sistemin tasarımı ve uygulamasını içerir. Sistem, dört adet PIC 16F877A mikrodenetleyicisi (1 Master, 3 Slave) ve C# ile geliştirilmiş bir grafik kullanıcı arayüzü (GUI) kullanılarak gerçekleştirilmiştir.

## Proje Özeti
- **Amaç:** Soğutma odalarının sıcaklıklarını izlemek ve kontrol etmek.
- **Haberleşme:** 
  - Mikrodenetleyiciler arası: **Half Duplex** (MAX487 entegresi ile).
  - GUI ile sistem: **Full Duplex** (iki MAX487 paralel bağlı).
- **Donanım:** 
  - 4 adet PIC 16F877A.
  - LM35 sıcaklık sensörü (-55°C ile +150°C arası ölçüm).
  - BCD display (CRC ve sıcaklık gösterimi).
- **Yazılım:** 
  - Mikrodenetleyiciler: CCS C ile programlandı.
  - GUI: C# platformunda geliştirildi.

## Sistem Nasıl Çalışır?
### Master Cihaz
- GUI ve Slave cihazlarla haberleşir.
- Veri alımı: 6 byte’lık paketler (Gönderici Adresi, Alıcı Adresi, ACK, Data Uzunluğu, Data, CRC).
- RDA kesmesiyle veri işlenir; ACK alındığında LED yanar.
- `make_packet` fonksiyonu ile Slave’lere veri gönderir.

### Slave Cihazlar
- LM35 ile ortam sıcaklığını ölçer.
- Gelen istenen sıcaklık ile mevcut sıcaklığı karşılaştırır, soğutucuyu kontrol eder.
- BCD display’de CRC ve sıcaklık gösterilir.
- `send_gui` ile sıcaklık verisi GUI’ye iletilir.
- Hata durumunda LED ile uyarı verir.

## C# GUI Arayüzü
- **COM Port Kontrol:** Bağlantı ayarları (baud rate, parity, data bit).
- **Transmitter:** İstenen sıcaklık ve ACK gönderimi.
- **Receiver:** Gelen veriyi gösterir (test amaçlı).
- **Sistem Ekranı:** Oda sıcaklıkları ve soğutucu durumu takibi.

![GUI Arayüzü](https://github.com/CelciusZ/Cooling-Plant-System/raw/master/GUI.PNG)

## Kurulum ve Kullanım
1. **Donanım Kurulumu:**
   - PIC 16F877A’ları MAX487 ile bağlayın (devre şemaları raporda).
   - LM35 ve BCD display’leri Slave’lere entegre edin.
2. **Yazılım Kurulumu:**
   - CCS C kodlarını mikrodenetleyicilere yükleyin.
   - C# GUI’yi Visual Studio’da derleyin.
3. **Sanal Portlar:**
   - VSPE ile iki sanal COM port oluşturun.
   - Serial redirector ile portları bağlayın ve emülatörü başlatın.
4. **Çalıştırma:**
   - GUI’yi başlatın, COM portu seçin ve sistemi kontrol edin.

## Ekran Görüntüleri
*(Buraya devre şemaları gibi ek görseller eklenebilir.)*

## Katkıda Bulunma
Her türlü öneri ve katkıya açığım! Issues veya PR ile ulaşabilirsiniz.

## Lisans
Bu proje kişisel bir çalışma olup, ticari kullanım için değildir.
