# Morris-Pratt-algorithm
Morris Pratt algoritmasının alice in wonderland metni üzerinde örneğinin gösterimidir.

Morris-Pratt algoritması, bir metin içindeki bir deseni (pattern) bulmak için kullanılan bir string arama algoritmasıdır. 
var iste kaçıncı indexte başladığını belirtmektedir.
<h1>Önemli ve Öneri</h1>
main metodunun içindeki String metin kısmında hali hazırda olan file.ReadAllText fonksiyonunun içine içeriğini inceleyeceğimiz text dosyasının yolunu yapıştırıyoruz.
yol içinde bulunan backslash(\) leri slash(/) ile değiştirmeyi unutmayınız.

örnekte olduğu gibi switch yapısında ilk 5 seçenekte olduğu gibi hazır metinler için hazırlanabilir.
6. seçenekte olduğu gibi string bir değişkenle birlikte kendi istediğimiz kelime de girilebilir.

<h1>fonksiyonun temel dönüş şekli </h1>

fonksiyon aradığımız patterni bulursa bir index değeri döndüreceği için bir int değişkenine atanarak kullanılması tavsiye edilmektedir.
eğer aranan veri bulunamamış ise -1 değerini döndürecektir.

<h1>fonksiyonun temel kullanım şekli</h1>

MorrisPratt(String metin, String kelime) şeklindedir.
String kelime aradığımız veridir.
String metin ise kelime verisini içinde aradığımız Stringtir.

fonksiyonu çağırdığımızda ilk başta metin ve kelimenin uzunlukları kullanılmak üzere değişkenlere atanmaktadır.
int pi dizisine = parcala(kelime) gönderilmektedir. burada kendi içinde bir patern oluşturuluyor.
bir for döngüsü içinde metin boyutu kadar dönmeye başlıyor
q 0dan büyük olduğunda ve kelimenin q. harfi metinin i. harfine denk olmadığında q = pi[q-1] eşitliği çağırılıyor.
kelime[q] metin[i] ye eşit ise q=q+1 eşitliği çağırılıyor.
q m ye yani kelime bulunduğunda i-m+1 geri gönderilerek index bulunmuş oluyor.
eğer for döngüsü içinde bu gerçekleşmez ise -1 döndürülerek kelimenin  bulunmadığı belirtiliyor.


<h1>Algoritmanın çalışma zamanı</h1>
Algoritmanın çalışma zamanı, metnin boyutuna (n) ve desenin boyutuna (m) bağlıdır.
karşılaştırma yapmak için oluşturulan tablo m işlem almaktadır.
Ardından, algoritma metin üzerinde bir tarama yapar ve desenin eşleştiği yerleri belirler. Bu işlem için n adet karakteri karşılaştırmak gereklidir.
Ancak, Morris-Pratt algoritması, daha önce eşleşme yapmış olduğu karakterleri bir daha karşılaştırmadan geçebilir.
Bu sayede, metnin tüm karakterleri üzerinde tekrar tekrar işlem yapmak zorunda kalmaz.
Bu optimizasyon sayesinde, algoritmanın toplam çalışma zamanı O(m + n) olarak hesaplanır.


<h1>Morris-Pratt algoritması için en iyi, en kötü ve ortalama sınırları</h1>

En iyi durum: Desen, metnin başlangıcında eşleşir. Bu durumda, algoritmanın çalışma zamanı O(m) olur.

En kötü durum: Metin içindeki her karakter, desenin son karakterine kadar eşleşir, ancak son karakter eşleşmez.
Bu durumda, algoritmanın çalışma zamanı O(m*n) olur.

Ortalama durum: Morris-Pratt algoritması, en kötü durumda bile Brute-Force algoritmasından daha hızlıdır ve çalışma zamanı O(m+n) 'dir.
Bu nedenle, algoritmanın ortalama durumda da oldukça verimli olduğu söylenebilir.








