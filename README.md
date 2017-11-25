(Ödevdeki raporun aynısınıdr.Rapor zorla olarak gereksiz bilgi ve boş yazılarla doldurulmaya mecbur bırakılmaktadır.)

SUDOKU ÇÖZÜCÜ

Mert Selimbeyoğlu

Bilgisayar Mühendisliği Bölümü

Kocaeli Üniversitesi

                                                                 mertselimb@hotmail.com




 
Özet
Projenin amacı multi thread kullanarak sudokuyu birçok noktadan çözmeye başlayıp ilk bitiren thread diğerlerini durdurup sudoku çözümünü kullanıcıya sunuyor.Bunu yaparken adım adım yazıp txt dosyasında saklanıyor.Proje multi thread kullanıyor derken kastedilen program çalışırken yeni işlemler başlatıldığıdır. [1]Bu işlemler birbirinden bağımsız çalışmaktadır. Thread(İplik) Kavramı ve Kullanımı İşletim sistemleri adlandırılmasında (terminoloji) çalışmakta olan programlara süreç (process) denilmektedir. İplikler süreçlerin farklı çizelgelenen akışlarıdır. Windows sistemleri iplik temelinde çizelgeleme yapmaktadır. Örneğin işletim sistemi P1 sürecinin T1 ipliğini 20ms kadar çalıştırmakta sonra kalınan yeri saklamaktadır, bu kez P1 sürecinin T2 ipliğine geçmektedir. Sonra aynı biçimde P2 sürecinin ve P3 sürecinin iplikleri çalıştırılmaktadır. Yeniden başa dönülüp işlem devam etmektedir. Birden fazla mikroişlemci bulunan sistemlerde (IntelDualCore), işletim sistemi her işlemci için ayrı bir çizelge oluşturup daha hızlı bir çalışma sağlamaktadır. İşletim sistemi ,işlemcilere iplikleri atamaktadır.
[2]Çözülen oyun sudokudur. Sudoku, her yaştan insanın temel mantıksal akıl yürütmelerle kolayca öğrenebileceği bir bulmaca oyunudur. Japonya'dan çıktığı bilinen oyun, japonca "Suuji wa dokushin ni kagiru" kelimelerinin birleşiminden "SUDOKU" tabirini almıştır. Oyunu tarif etmek için ise "rakam yerleştirme" demek yerinde olacaktır. Sudoku bulmacaları, büyüklüğüne ve çesidine göre isimlendirilmiştir. En meşhur olan resimde gördüğümüz 9x9 boyutlarındaki Klasik Sudoku çeşididir. Klasik sudoku, 9x9 boyutlarında, 9'ar karelik 9 bölgedeki 81 kareden oluşmaktadır. 1'den 9 kadar olan rakamlar bu 81 kareye belirlenmiş kurallara göre yerleştirilerek oynanır.
Bir sudoku bulmacasında resimdeki gibi bazı rakamlar sudoku içine yerleştirilmiş olarak verilir. Geriye kalan rakamlar ise altta belirtilen kurallar çerçevesinde yerleştirilmesi istenir.

Tüm sudoku çeşitleri için geçerli olan üç temel kural vardır.
* Her satırda tüm rakamlar bulunmalı ve bu rakamlar sadece birer defa yer almalıdır.
* Her sütunda tüm rakamlar bulunmalı ve bu rakamlar sadece birer defa yer almalıdır.
* Her bölgede tüm rakamlar bulunmalı ve bu rakamlar sadece birer defa yer almalıdır.

Sudoku Çeşitleri
50 ye yakın sudoku çeşidi bulunmaktadır. Sürekli yeni türleri üretilmektedir.Bunlardan bazıları; Klasik Sudoku, Bölgesel Sudoku, Ardışık Sudoku, Ardışıksız Sudoku, Multi Sudoku, Köşegen Sudoku, Toplamlı Sudoku, Zincir Sudoku vb. 21 adet sudoku çeşidini ve bu çeşitlere ait kuralları öğrenmek için bakınız.

Boyutuna Göre Sudokular
Sudoku oyunu 4x4, 6x6, 9x9 gibi bir çok boyutta oynanabilirler.
4x4 sudoku, 4'er karelik 4 bölgedeki 16 kareden oluşmakta, 1'den 4'e kadar olan rakamlar bu üç temel kurala göre yerleştirilmelidirler.
6x6 sudoku, 6'şar karelik 6 bölgedeki 36 kareden oluşmakta, 1'den 6'ya kadar olan rakamlar bu üç temel kurala göre yerleştirilmelidirler.
9x9 sudoku, 9'ar karelik 9 bölgedeki 81 kareden oluşmakta, 1'den 9'a kadar olan rakamlar bu üç temel kurala göre yerleştirilmelidirler.
1.	Giriş
Proje amacı insanların çözmesi çok zor olan sudokuların çözülmesidir.Yazdıktan sonra benimde gördüğüm durum bazı sudokuların inanılmaz uzunlukta çözümlerinin olduğudur.Bunu bir insanın çözebiliyor olması bile kendi başına inanılmazdır.

[3]Sudoku Japonya’da 1984 yılında bir bulmaca dergisinde yayınlanmıştır. Derginin ait olduğu şirketin kurucusu Maki Kaji’dir. Keşfedilmesindeki kaynak Latin karesidir. Sudokunun bildiğimiz şekline gelmesinde ise emekli mimar Howard Garn etkili olmuştur. Garn’ın bulmacaları 1979 yılında bir dergide yayınlanmıştır. Ancak keşfi yapan kişi sudokunun meşhur olduğunu göremeden hayatını kaybetmiştir. 1997 yılında sudoku, bulmaca kitabından bilgisayar ortamına taşınmış ve sudoku hazırlanması için program geliştirilmiştir.
The Times gazetesi sudokuya 2004 yılında yer vermiştir. Böylece son derece popüler hale gelmiş ve telefonlarda, bilgisayarlarda yer almaya başlamıştır. Dünyada ve ülkemizde sudoku hakkında ilk kitap Nevzat Erkmen tarafından yayınlanmıştır. Erkmen, aynı zamanda Dünya Zekâ Oyunları Federasyonu’nun kurucu üyelerindendir ve Türkiye temsilcisidir. Ayrıca sudokuyu ülkemizle tanıştıran isimdir. 2005 yılına gelindiğinde Sky One ve BBC gibi kanallarda sudoku şovları ve yarışma programları düzenlenmiştir.
İlk dünya sudoku şampiyonası 2006 yılında İtalya’da yapılmıştır. 2005 yılına kadar her ülke kendi içerisinde yarışmalar düzenlemiş olsa da uluslararası organizasyon olması bakımından önemlidir. Bu organizasyonlar arasında İtalyanlar dünya sudoku şampiyonası düzenlemek istediklerini belirtmişlerdi.
Proje şu ana kadar denediğim her sudokuyu çözmüştür.Sudoku zorluğuna göre süre uzarken.Hata yaptığı yada sonuca ulaşamadığı bir durum olmadı.Her deneme başarılı olduğu için %100 kabul ediyorum başarı oranını.
2.	Temel Bilgiler
[7]C# (si şarp şeklinde telaffuz edilir), Microsoft'un geliştirmiş olduğu yeni nesil programlama dilidir. Yine Microsoft tarafından geliştirilmiş .NET Teknolojisi için geliştirilmiş dillerden biridir.
Microsoft tarafından geliştirilmiş olsa da ECMA ve ISO standartları altına alınmıştır.
C programlama dilinde bir tam sayı değişkeni 1 atırmak için ++ soneki kullanılır. C++ dili adını, C diliyle Nesneye Yönelimli Programlama yapabilmek için eklentiler (C With Classes) almıştır. Benzer şekilde C++ diline yeni eklentiler yapılarak ((C++)++) bir adım daha ileriye götürülmüş ve tamamen nesneye yönelik tasarlanmış C# dilinin isimlendirilmesinde, + karakterlerinin birbirlerine yakınlaşmış hali ve bir melodi anahtarı olan C# Major kullanılmıştır.
Bu dilin tasarlanmasına Pascal, Delphi derleyicileri ve J++ programlama dilinin tasarımlarıyla bilinen Anders Hejlsberg liderlik etmiştir.
[8]Birçok alanda Java'yı kendisine örnek alır ve C# da java gibi C ve C++ kod sözdizimine benzer bir kod yapısındadır. .NET kütüphanelerini kullanmak amacıyla yazılan programların çalıştığı bilgisayarlarda uyumlu bir kütüphanenin ve yorumlayıcının bulunması gereklidir. Bu, Microsoft'un .Net Framework'u olabileceği gibi ECMA standartlarına uygun herhangi bir kütüphane ve yorumlayıcı da olabilir. Yaygın diğer kütüphanelere örnek olarak Portable.Net ve Mono verilebilir.
Özellikle nesne yönelimli programlama kavramının gelişmesine katkıda bulunan en aktif programlama dillerinden biridir .NET platformunun anadili olduğu bazı kesimler tarafından kabul görse de bazıları bunun doğru olmadığını savunur.
C#, .NET orta seviyeli programlama dillerindendir. Yani hem makine diline hem de insan algısına eşit seviyededir. Buradaki orta ifadesi dilin gücünü değil makine dili ile günlük konuşma diline olan mesafesini göstermektedir. Örneğin; Visual Basic .NET (VB.NET) yüksek seviyeli bir dildir dersek bu, dilin insanların günlük yaşantılarında konuşma biçimine yakın şekilde yazıldığını ifade etmektedir. Dolayısıyla VB.NET, C#.NET'ten daha güçlü bir dildir diyemeyiz. Programın çalışması istenen bilgisayarlarda framework kurulu olması gerekmektedir. (Windows 7 ve Windows Vista'da .NET Framework kuruludur)
[1]ECMA tarafından C# dilinin tasarım hedefleri şöyle sıralanır:
•	C# basit, modern, genel-amaçlı, nesneye yönelik programlama dili olarak tasarlanmıştır.
•	Çünkü yazılımın sağlamlılığı, güvenirliliği ve programcıların üretkenliliği önemlidir. C# yazılım dili, güçlü tipleme kontrolü (strong type checking), dizin sınırlar kontrolü (array bounds checking), tanımlanmamış değişkenlerin kullanım tespiti, (source code portability), ve otomatik artık veri toplama gibi özelliklerine sahiptir.
•	Programcı portatifliği özellikle C ve C++ dilleri ile tecrübesi olanlar için çok önemlidir.
•	Enternasyonal hale koymak için verilen destek çok önemlidir.
•	C# programlama dili sunucu ve gömülü sistemler için tasarlanmıştır. Bununla birlikte C# programlama dili en basit işlevselli fonksiyondan işletim sistemini kullanan en teferruatlısına kadar kapsamaktadır.
•	C# uygulamaları hafıza ve işlemci gereksinimleri ile tutumlu olmak uzere tasarlanmıştır. Buna rağmen C# programlama dili performans açısından C veya assembly dili ile rekabet etmek için tasarlanmamıştır.
C# konusunda eleştiriler tabii ki var. En önemlisi using ile hangi referansları kullanacağımızı çok iyi bilmeliyiz. Ayrıca süslü parantez "{}" ve noktalı virgül ";" karakterlerini çok sevmemiz ve asla unutmamamız gerekmektedir
Performans
•	Diğerleri gibi Sanal Makine'ye dayalı dillerden biridir, C# programlama dili direkt yerleşik kod'a derleyen dillerden daha yavaştır.[1].
Platform
•	.NET Microsoft uygulama bonservisi Windows üzerinde geçerlidir. Fakat C# programlarını Windows, Linux veya MacOs üzerinde yürüten başka uygulamalar da yer almaktadır. Mono (software) ve DotGnu [1].
Güvenlik
•	C# sanal makineye dayalı bir dil olduğundan kaynak kodlarının korunması zordur. Kaynak kodları karıştırıp şifreleyen ek uygulamalar ile güvenlik düzeyi artırırsa da tam olarak koruma sağlanmaz.


3.	Sudoku Bilgisayar Çözümleri
[10]Derinine arama algoritması her Sudoku problemini çözebilecek olmasına rağmen hesaplamalar yönünde etkisiz kalmaktadır ve pekte sık kullanılmaz. Sudokunun ciddi problem çözümlerini oluşturmak için iki yaklaşım vardır. 1- Verilen Sudokunun zorluk derecesinin belirleyip olabildiğince insanların çözüm metoduna benzetmeye çalışmak. 2- Daha hızlı hesaplamalar yaparak olabildiğince etkili çözümler bulmak.

İki yaklaşımda da bilgisayar programı Sudoku oyunlarının kapsamlı çözümlerini bulabilecek yeteneğe sahiptir. Bu aşamada hangisinin geçerli olup olmadığına karar vermeyi insan denemelerine benzer tahminlerde bulunmasına göre yaparız. İnsan stili çözücüler tipik olarak işaretleme, olasılıkları değerlendirme, hücreleri eşleştirme ve diğer yolları kullanarak hücre değerlerini elemek ve karar vermek için derinine arama işlemlerini tekrarlı olarak uygulayarak çözümü bulur. Bu arama metodu doğru sonucu bulana kadar her olasılığı deneme fikrine dayanır.yani tüm çözümler kümesinde derinlemesine bir arama yapmak anlamına gelir. Arama esnasında eğer denemekte olduğunuz yol tıkandıysa bu yola girdiğiniz noktaya, geldiğiniz yoldan geri dönülür. Yani diğer bir alternatif yola gireceğiniz yere gelinir ve onu denersiniz. Eğer o yoldaki tüm alternatifleri tarayarak sonucu bulamadıysanız bir önceki kontrol noktasına dönerek diğer daha kapsamlı alternatif yolu denersiniz. Eğer tüm durumları taramış ve sonucu bulamamışsanız arama başarısız olmuştur demektir. Bu işlem sürekli kendini çağıran yani yinelemeli bir yapı kullanılarak oluşturulur. Bu işlemde her duruma fazladan bir değişken atanır ve bu durumun ulaştığı durumların değerleri bu durumun bu değişkenine atanır. Bu değer tutularak bir sonraki yinelemeli çağırılır. Aramada hızlandırma yapmak için bir değer seçildiğinde yinelemeli çağırma yapılmadan algoritma hem ilerideki kontrol noktalarından değerleri uyuşmazlık göstereni siler hem de sınırlamalara bakarak hangi alternatifin taranması gerektiğini belirler. Uygulanacak her çeşit operasyon zorluk değeri olarak atanabilir. Bu değerlerin toplamı da bulmacanın zorluk derecesini belirler.
Standart Sudoku problemleri için derinine arama yöntemi en etkili metot olmasına rağmen Donald Knuthun tam matris kapsamlarının çözümü için Bağlantılarda Gezme algoritması da popülerliğe sahiptir. Bu algoritma çift yönlü dairesel listeler üzerine kurulmuştur. Bu algoritmada Knuth Seyrek Matris adında diğer bir değişle kısa olarak DLX olarak bilinen ve sadece 1lerin bulunduğu bir matris tanımlamıştır. Her zaman matristeki her düğüm için aynı satırdaki 1ler sol ve sağ taraftaki düğümleri, aynı sütundaki 1ler ise üst ve alttaki düğümleri gösterir ve ayrıca her kolunun bir başlığı bulunur. Matristeki her satır ve sütun dairesel çift yönlü listenin düğümlerinden birine karşılık gelir. Sudoku için DLX matrisi olası tüm hareketleri ve geçerli çözümü sağlayacak bu hareketlerin sınırlarına karşılık gelir. DLX matrisinde her satır belli bir sayıyı belli bir hücreye yerleştirmek gibi olası bir harekete karşılılık gelir. Böylece DLX satırları <d,r,c> şeklinde etiketlenebilir. ( d,r ve c 1den 9a birer rakamdır.) Mesela <2,5,7>, 2 rakamının 5. satır ve 7. sütun hücresine yerleştirilmesi anlamına gelir. Bu hücrede olabilecek 9 rakam vardır ve 9x9=81 hücre vardır. Yani 9x81=729 DLX satırı olur. Ancak buradaki satırlarda Sudokunun her rakamın yalnız bir kez bulunması gereken yerler göz önünde tutulmamıştır olur. DLX matrisindeki her kolon çözümün geçerli olabilmesi için gereken şartlara karşılık gelir. 1-Her bir satır ve sütundaki hücreler yalnız bir rakam içerebilir. 2-Her bir rakamdan her satırda yalnız bir tane bulunabilir. 3-Her bir rakamdan her sütunda yalnız bir tane bulunabilir. 4- Her bir rakamdan her bölgede yalnız bir tane bulunabilir.
Örneğin koşul-1 (satır-sütun) için <5,7>, 5. satır ve 7. sütun yalnızca bir adet rakam içerebilir. DLX matrisinin bu koşul kolonunda <1,5,7>,<2,5,7>,  , <9,5,7> satırları için birer 1 bulunur. ( 5.satır ve 7. sütun hücresinde 1den 9a kadar rakam bulunabileceği için.). bu kolonun geri kalan DLX satırları için değerleri 0 olur. Geçerli çözüm için bu 9 DLX satırından biri seçildiği andan itibaren 5. satır ve 7. sütun hücresi yalnızca o seçilen değeri içerir. Bu doğrultuda incelenecek olursa 9 satır ve 9 sütun olduğu için DLX matrisinin 81 adet koşul-1 sütunu olur. Örneğin koşul-2 (rakam-satır) için <2,7>, 5. satırda 2 rakamının sadece 1 kez bulunması anlamına gelir. DLX matrisinin koşul-2 kolunu, <2,5,1>,<2,5,2>,  ,<2,5,9> DLX satırları için 1 değeri alır. (2 rakamı 5. satırın 9 hücresinden birinde olabilir.) Geri kalan DLX satırları için sütun değeri 0 olur. Geçerli çözüm için bu 9 DLX satırından sadece biri seçildiğinde 2 rakamından 5. satırda sadece 1 tane bulunmuş olur. Burada 9 satır ve 9 sütun bulunduğundan DLX matrisinin 81 koşul-2 sütunu vardır. Benzer şekilde koşul-3 (rakam-sütun) ve koşul-4 (rakam-bölge) koşulları da DLX matrisinde 81er tane sütuna sahiptirler. Sonuç olarak DLX matrisinde 729 satır ve 324 sütun bulunur. Her DLX satırı tam 4 adet 1 içerir ve 324-4=320 de 0 bulundurur. Örneğin 2 rakamını 5. satır ve 7. sütuna yerleştirmek anlamına gelen <2,5,7> DLX satırında satır-sütun koşulu için <5,7>, rakam-satır koşulu için <2,5>, rakam-sütun koşulu için <2,7> ve rakam-bölge koşulu için <2,6> kolonları 1 değeri alır. Bu DLX satırı için geriye kalan tüm DLX sütunları 0 değerini alır. Bu düşünde çerçevesinde her DLX sütunu da 9 adet 1 ve 729-9=720 tane de 0 içerir. Böylelikle DLX matrisi seyrek matris olur ve tüm düğümlerin sadece 1 değerleri için uygulandığından oldukça hız kazanılmış olur.
Knuthun bu algoritması Sudoku oyununu tam matris kapsaması problemine dönüştürerek uygulanır. Günümüzde bu metot birçok Sodoku programcısı tarafından tercih edilir. Kolay implementasyonu, ilgili doküman ve kaynak koda kolay ulaşımı ve koşum zamanının kısalığı tercih edilme sebepleri arasında gösterilebilr


3.1 Algoritma
[11]Algoritma şu şekilde işliyor:

fonksiyon çöz(matrix, çözümler):

  eğer bütün sütunlar matrix'den çıkarılmışsa, çözümleri döndür

  sütun := sıradakisütun()
  seç(sütun)
  sütun altındaki her node için:
      çözümler.ekle(node)
      bu nodun sağındaki nodların bulunduğu sütunları seç
      çöz(matrix, çözümler) # recursive bir şekilde matrix'in geri kalanı çözülüyor
      çözümler.çıkar(node)
      sağdaki seçilmiş sütunları seçimini iptal et.

  sütun seçimini iptal et.

Yukarıdaki çöz metodu, recursive, backtracking, depth-first bir algoritma. Backtrack, çıkarılmış node'ları geri ekleme ile sağlanıyor. Yukarıda da bahsettiğimiz gibi, bu ekleme çıkarma çok kolay bir işlem, bu yüzden algoritma bu kadar verimli.
Yukarıdaki pseudo-kod yeterince açıklayıcı olamamış olabilir. O yüzden bir de sözlü olarak açıklayayım. Hatırlarsanız, matrix içindeki sütunlar, karşılamamız gereken gereksinimleri, satırlar ise, bu gereksinimlerin biri veya birkaçını sağlayan seçenekleri gösteriyordu. Algoritma önce bir gereksinim seçiyor, ve bunu matrix'den kaldırıyor. Bunun matrix'den kaldırılması, bu gereksinimin sağlanmış olduğunu anlamına geliyor diye düşünebiliriz. Algoritma ardından, bu sütun altındaki nodları sırasıyla ilerliyor. Bu sütun altındaki her bir node, sütunda temsil edilen gereksinimin karşılanabileceği farklı bir seçenek. Bu seçeneklerden biri çözümler listesine eklendiğinden, o seçeneğin sağladığı diğer gereksinimler de matrix içerisinden kaldırılıyor. Sonra, recursive bir şekilde matrix tekrar işleme sokuluyor. Recursion tamamlandıktan sonra, yapılan şeyler geri alınıyor, bir sonraki nod çözümlere eklenip, böylece devam ediliyor.
Bir de örnek yapalım;
   A B C D E
1| 1 0 1 0 0
2| 1 0 0 1 0
3| 0 1 0 1 1
Algoritma, önce A sütununu kaldırarak başlayacak. İçinde 1 bulunan satırları sırasıyla çözümlere ekleyecek. Önce 1. satırı ekledi diyelim. Böylece, C sütununu da seçmiş oldu. Şimdi, geriye kalan matrix üzerinde arama yapacak

   B D E
3| 1 1 1
Geriye sadece 3. satır kaldı. İkinci satır da silindi, çünkü, A seçeneğini sağlayan birden fazla satırı aynı anda seçemeyiz. Bu adımda, 3. satırı seçmek bütün gereksinimleri sağlıyor. Dolayısıyla, (1 ve 3) ilk sonuç olarak döndü. Algoritma bu noktada, backtrack edip, A sütununu seçtiğimiz noktaya dönüyor.

   A B C D E
1| 1 0 1 0 0
2| 1 0 0 1 0
3| 0 1 0 1 1
Şimdi sırada satır ikiyi seçip devam etmek var.

   B C E
3| 1 0 1
Geriye sadece tek bir satır kaldı, ancak bu satır geriye kalan gereksinimlerimizi karşılamadı. Dolayısıyla bir sonuç döndüremedik. Algoritma bu noktada, başa dönüp, diğer sütunları seçerek aynı şeyleri deneyecek.


3.2 Sudoku ile algoritmanın bağlantısı

[11]Gelelim, bütün bunların sudoku ile bağlantısına. Eğer sudoku'yu bir exact cover problemine dönüştürürsek, bu algoritmayı kullanarak istediğimiz sudokuyu çözebiliriz. Hatırlarsanız, kullandığımız matrix'de gereksinimler ve seçenekler vardı. Peki sudoku için gereksinimlerimiz nedir?
•	Her hücre'de, birden dokuza kadar bir sayı, ve sadece bir sayı olmalı. (81 hücre olduğundan 81 gereksinim)
•	Her satırda, birden dokuza kadar her sayıdan birer tane olmalı. (9 hücre x 9 sayı = 81 gereksinim)
•	Her sütunda, birden dokuza kadar her sayıdan birer tane olmalı. (9 hücre x 9 sayı = 81 gereksinim)
•	Her 3x3 lük bölgede, birden dokuza kadar her sayıdan birer tane olmalı. (9 hücre x 9 sayı = 81 gereksinim.)
Toplamda, bir sudoku oyununda, sağlanması gerekn 324 gereksinim var. Peki elimizdeki seçenekler neler?
Örneğin, 1.satır 1.sütunda 1 sayısının olması bir seçenek. Aynı hücrede 2 olması ayrı bir seçenek. Dolayısıyla, her hücre için, 9 seçeneğimiz var. 9x9'luk bir sudoku tahtasında, 81 hücre olduğu için, 9x81=729 farklı seçeneğimiz var.
Her bir seçenek, 4 gereksinimi karşılayacak. Örneğin, 1. satır, 1. sütunda 1 olması seçeneği:
•	O hücrede bir sayı bulunması gereksinimini
•	O satırda 1 bulunması gereksinimini
•	O sütunda 1 bulunması gereksinimini
•	0 3x3lük bölgede 1 bulunması gereksinimini
Evet, sudoku çözmek için, önce bu matrix'i oluşturmak gerekiyor. Ancak, bu matrix'i oluşturmaya başlamadan önce, bunu Python'da nasıl kodlayabileceğimizi bir düşünelim. Bildiğiniz üzere, Python daha üst seviye bir programlama dili ve bu dildeki veri yapıları, C'ye göre farklı. İnternette, algorithm X'in, Python ile 30 satırda yazılmış şöyle bir versiyonunu buldum:
def solve(X, Y, solution=[]):
    if not X:
        yield list(solution)
    else:
        c = min(X, key=lambda c: len(X[c]))
        for r in list(X[c]):
            solution.append(r)
            cols = select(X, Y, r)
            for s in solve(X, Y, solution):
                yield s
            deselect(X, Y, r, cols)
            solution.pop()

def select(X, Y, r):
    cols = []
    for j in Y[r]:
        for i in X[j]:
            for k in Y[i]:
                if k != j:
                    X[k].remove(i)
        cols.append(X.pop(j))
    return cols

def deselect(X, Y, r, cols):
    for j in reversed(Y[r]):
        X[j] = cols.pop()
        for i in X[j]:
            for k in Y[i]:
                if k != j:
                    X[k].add(i)
Burada, satır ve sütunlar, bir çift-link liste yerine, Python sözlüklerinde tutulmuş. Örneğin, en başta verdiğim şu örneği düşünelim:
X = {1,2,3,4,5}
S = {{1,3},{1,4},{2,4,5}}
Bunu, yukarıdaki yöntem, bunu şu hale getiriyor;
X = {1:{'A','B'},
     2:{'C'},
     3:{'A'},
     4:{'B','C'}
     5:{'C'}}

Y = {
    'A':[1,3],
    'B':[1,4],
    'C':[2,4,5]
Satırlar ve sütunlar ayrı ayrı Python sözlükleri içerisindeler. Satırlardan sütunlara hızlıca erişmek için Y, sütunlardan satırlara erişmek için X sözlüğünü kullanıyor. Algoritmanın geri kalanı algorithm X ile aynı.

4.	Sonuçlar
Backtracking algoritması her sudokuyu kesin olarak çözüyor.Tek değişken ise zaman oluyor.Bazı sudokular saniyeler alırken bazıları uzayabiliyor.Aslında normalde sudoku uygulamaları bu kadar uzun süreli sonuçlar vermiyor.Ama çözerken adımları strign formatında aldığım için süre 50-60 katına çıkıyor saliseler alan algoritma en zor olanda (150000 deneme ile çözülen) 15 dakikayı bulabiliyor.
5.	Kaynakça

1.	https://sudoku.matematiktutkusu.com/31-sudoku-nedir.html
2.	http://bidb.itu.edu.tr/seyirdefteri/blog/2013/09/08/thread(iplik)-kavram%C4%B1-ve-kullan%C4%B1m%C4%B1
3.	http://www.ekocbiyik.com/tag/sudoku-algoritmasi/
4.	https://en.0wikipedia.org/index.php?q=aHR0cHM6Ly9lbi53aWtpcGVkaWEub3JnL3dpa2kvU3Vkb2t1X3NvbHZpbmdfYWxnb3JpdGhtcw
5.	https://tr.0wikipedia.org/wiki/Sudoku
6.	http://www.sudokudragon.com/sudokuhistory.htm
7.	http://bilgihanem.com/sudoku-nedir-nasil-oynanir/
8.	http://www.csharpnedir.com/articles/?cat=cs&title=C# / VC#/.NET
9.	https://tr.0wikipedia.org/index.php?q=aHR0cHM6Ly90ci53aWtpcGVkaWEub3JnL3dpa2kvQ19TaGFycA
10.	http://sudoku.blogcu.com/sudoku-bilgisayar-cozumleri/558391
11.	https://www.google.com.tr/url?sa=t&rct=j&q=&esrc=s&source=web&cd=10&ved=0ahUKEwjTqvCMjMvXAhUOLlAKHclACdEQFghtMAk&url=https%3A%2F%2Fforum.ubuntu-tr.net%2Findex.php%3Ftopic%3D21634.0&usg=AOvVaw2d5VO8NVnwI7_9m8BHDLZY
12.	https://www.google.com.tr/url?sa=t&rct=j&q=&esrc=s&source=web&cd=8&ved=0ahUKEwjTqvCMjMvXAhUOLlAKHclACdEQFghgMAc&url=http%3A%2F%2Fysar.net%2Falgoritma%2Fexact-cover-dancing-links-ve-sudoku-cozme.html&usg=AOvVaw2JnqfVpA_TAsIwcU09ygVg
13.	https://coderanch.com/t/665173/java/implement-multi-threading-sudoku-solver
14.	https://www.codeproject.com/Articles/12605/Sudoku-Suduku-Solver
15.	https://github.com/cfperea/multithreaded-sudoku
16.	https://www.youtube.com/watch?v=gN8xrMwrLSc
17.	https://www.google.com.tr/search?ei=uoQMWpijNsXbwQLzprLgAQ&q=label+list+c%23+2d&oq=label+list+c%23+2d&gs_l=psy-ab.3..33i22i29i30k1l3.5799.6407.0.7210.3.3.0.0.0.0.139.389.0j3.3.0....0...1.1.64.psy-ab..0.3.388...0i22i30k1.0.ylG1to13dDQ
18.	https://www.youtube.com/watch?v=9naReRXp9eM&t=461s
19.	https://see.stanford.edu/materials/icspacs106b/H19-RecBacktrackExamples.pdf
 

