**4. Hafta **

Hafta --*Webin Devamı, Güvenlik ve Büyük Resim*

TARİH:26 Ekim  Pazartesi-

KONU: *Web isteğinin içinde başka neler taşınıyor?*

**##Araştırma Sorularım**
*1)HTTP status code nedir? 2xx, 4xx ve 5xx grupları ne anlatır?*
*2)HTTP header nedir?*
*3)Cookie nedir?*
*4)Session nedir?*
*5)Authentication ve Authorization arasındaki fark nedir?*
*6)Bir kullanıcı giriş yaptıktan sonra sistem onu sonraki isteklerde nasıl tanıyabilir? Farklı yöntemleri araştırın*


**##Gün Sonunda Teslim Edeceğim Notlar**
1)Basit bir login senaryosunu kullanıcıdan sunucuya ve geri dönüşe kadar çizerek anlatın.

2)Authentication ve Authorization için ayrı ayrı birer örnek bulun.

3)Status code gruplarından sık kullanılan birkaç örneği araştırıp not edin.

-------------------------------------

**1.SORU: HTTP status code nedir? 2xx, 4xx ve 5xx grupları ne anlatır?**

***HTTP Durum Kodları Nedir?***
*HTTP durum kodları, istemci ve sunucu arasındaki iletişimin durumunu bildiren 3 haneli sayılardır. İsteklerin başarılı ya da hatalı olduğunu belirtir.*

*2xx başarı, 4xx istemci/erişim kaynaklı sorun, 5xx sunucu hatası sınıfıdır. *

**2xx Grubu:HTTP protokolünde başarılı bir şekilde tamamlanan bir isteği belirtir. Bu kodlar, sunucunun isteği başarılı bir şekilde işlediğini ve istemcinin isteğine olumlu bir yanıt verdiğini gösterir.**

**4xx Grubu:Bir sayfanın yönlendirildiği veya taşındığı anlamına gelir.**

**5xx Grubu:Sunucunun isteği yerine getiremediğini ve bir hata veya sorunla karşılaştığını belirtir. Bu kodlar, genellikle sunucu tarafında bir sorun olduğunda kullanılır ve istemcinin hatası değildir.**

![statuscode](images/statuscode.png)

---------------

**2.SORU: HTTP header nedir?**

*HTTP başlıkları, bir HTTP isteği veya yanıtı hakkında ek bilgiler taşıyan anahtar-değer çiftleridir. İstemci ve sunucunun isteği, yanıtı ve değiş tokuş edilen verileri nasıl işleyeceğini anlamasına yardımcı olurlar.*

![header](images/header.webp)


**En Yaygın Kullanılan HTTP Headers Türleri ve Görevleri**

*Kimlik ve Yetkilendirme Header’ları*

- Authorization
- WWW-Authenticate
- Proxy-Authorization

*İçerik ve Format Kontrolü Header’ları*

- Content-Type
- Content-Length
- Accept/Accept-Encoding

*Önbellekleme ve Performans Header’ları*

- Cache-Control
- ETag
- Expires

**HTTP Header Neden Önemlidir?**

1=Güvenliği artırır.
2=Performansı iyileştirir.
3=İçerik ve veri formatını kontrol eder.
4=iletişimi standartlaştırır.

--------

**3.SORU: Cookie(Çerez) nedir?**

**Cookie (Çerez):** Web tarayıcıları tarafından kullanıcının cihazında saklanan küçük veri dosyalarıdır.Kullanıcıların tercihlerini ve etkileşimlerini izler.
Cookie türleri arasında oturum, kalıcı ve üçüncü taraf cookie'ler bulunur.

**Cookie Türleri:**

- Oturum Çerezleri
- Kalıcı Çerezler
- Üçüncü Taraf Çerezleri

![cookie](images/cookies-nedir.png)

----

**4.SORU: Session (Oturum) nedir?**

**Session(oturum):** Oturumlarda cookieler gibi kullanıcı bilgilerinin tutuldugu bölümlerdir.

Sessionların cookielerden en önemli farkları sessionlar kullanıcının bilgisayarında değil sunucuda tutulurlar. Böylece daha güvenlidirler.

-----------------------

**5.SORU:Authentication ve Authorization arasındaki fark nedir?**

**Authentication (Kimlik Doğrulama):** Bir kişinin iddia ettiği kişi olduğunu doğrulayan bir süreçtir.
**Authorization (Yetkilendirme):** Authentication dan sonra yani kullanıcı doğrulandıktan sonra hangi verilere uygulamalara veya hangi işlemleri yapabileceğini belirler.

*Authentication = Kim olduğunu doğrulama.*
*Authorization = Neye izin verildiğini belirleme.*

![aa](images/aaa.jpg)

------

**6.SORU:6)Bir kullanıcı giriş yaptıktan sonra sistem onu sonraki isteklerde nasıl tanıyabilir? Farklı yöntemleri araştırın**
Bir kullanıcı sisteme kullanıcı adı ve şifresiyle giriş yaptıktan sonra sistemin her istekte tekrar şifre sormaması gerekir. Bunun için kullanıcının giriş yaptığını gösteren bazı bilgiler saklanır veya sonraki isteklere eklenir. Bu işleme oturum yönetimi (Session Management) denir.

**Kullanıcıyı tanıma yöntemleri**

1)Session ıd
2)Access Token ve Refresh Token
3)JWT (JSON Web Token)
4)Cookie(Çerez)


-------

**1:Basit bir login senaryosunu kullanıcıdan sunucuya ve geri dönüşe kadar çizerek anlatın.**

![login](images/login.png)


-------

**Authentication ve Authorization için ayrı ayrı birer örnek bulun.**

**☺ Authentication Örneği (pasaport doğrulama)**

- Günlük Hayat Örneği: Bir havalimanında uçağa binmeden önce pasaport kontrolünden geçmeniz. Görevli pasaportunuza ve yüzünüze bakarak sizin gerçekten pasaportta yazan kişi olup olmadığınızı doğrular.



------

**Status code gruplarından sık kullanılan birkaç örneği araştırıp not edin.**

- **200 OK:** İnternette sorunsuz açılan her web sayfasının arkasındaki başarı kodu.
- **301 Moved Permanently:** Bir web sitesi adresini değiştirdiğinde sizi yeni adrese otomatik götüren yönlendirme kodu.
- **404 Not Found:** Yanlış yazılmış veya silinmiş bir linke tıkladığınızda karşınıza çıkan "Sayfa Bulunamadı" hatası.
- **500 Internal Server Error:** Sosyal medya veya web siteleri çöktüğünde ekranda beliren "Sunucu Hatası".

--------------------------


**##Kaynaklar**

1)https://www.geeksforgeeks.org/http-status-codes

2)https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers

3)https://www.geeksforgeeks.org/http-headers

5)https://turkbilisim.com.tr/blog/cookie-nedir-ve-ne-ise-yarar/

6)https://www.geeksforgeeks.org/session-management-in-web-development

7)https://www.geeksforgeeks.org/difference-between-authentication-and-authorization

8)https://elevoo.io/tr/blog/https-headers#http-headers-neden-onemlidir

9)https://www.natro.com/blog/http-statu-kodlarinin-anlamlari-nelerdir/

--