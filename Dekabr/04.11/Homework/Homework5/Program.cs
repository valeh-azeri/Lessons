using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Naming Convention in C#
            /*Değişken isimleri sayısal ifadelerle başlayamaz
özel karakter olarak sadece _ karakteri kullanılabilir
değişken isimlerinde sayısal karakterler kullanılabilir ancak ilk harf sayısal karakter olamaz.
Türkçe karakter dışındaki harfler kullanılması önerilir. Kullanılırsa da program çalışmaya devam eder. 
Ancak sosyal medyada yazılım gruplarında Türkçe karakter kullanılması durumunda ne olur diye sorduğumda şu cevapları aldım.
“ar export ederken Türkçe karakterden dolayı compilation error almıştım bir sebebi bu olabilir.”, 
“ASCII kodlarda 0..127 arası sabittir. 128..255 arası ise karakter kodlamasına göre farklı anlamlar ve şekillerde olabilmektedir. 
ayrıca Unicode karakter kullanıyorsanız bunlar 2 byte uzunluğundadır ve fontun tipine göre dahi farklılık gösterebilir.
bu durumda ingiliz harflerinin bulunduğu bölüm olan ilk 127’lik bölümdeki karakterler(noktalama işaretleri falan hariç) kullanılır”
Değişken isimleri tekildir.
Büyük küçük harfe duyarlıdır.
Ayrıca değişken isimlerini anlamlı yazmalıyız.Bir değişkene verilen x, y, z isimleri ileriki zamanlarda tekrar bakıldığında ya da 
farklı bir yazılımcı tarafından bakıldığında x, y, z’nin neye denk geldiğini anlayabilmesi için kodun en başına gidip kontrol etmesi gerekir.
Bu da karmaşık ve uzun olan kod sayfalarında çalışmayı zorlaştıracaktır. bu isimlendirme yerine değişken neye denk geliyorsa anlamlı olacak 
şekilde yazılmalı.Kısaltma yapılacaksada anlamlı bir şekilde yapılmalıdır. Örneğin kullanıcının Adı ve Soyadını tuttuğumuz değişkenin adına as 
yerine adSoyad yazarak daha anlamlı hale getirebiliriz.



Bir de yapıldığında kodun okunabilirliğini artıran ve ekibe sonradan dahil olan kişilerin geçmişte yazılanları daha iyi anlamaları 
için hazırlanmış bazı standartlar vardır. Bu standartlara uygun kod yazıldığında hızımızı da arttırabiliriz.

Pascal Standardı
Değişken içinde ki kelimelerin baş harfleri büyük diğer harfleri küçük olacak şekilde yazılır.

Örnek: int OgrenciNumarasi = 52;

            Camel Standardı
Değişken içindeki kelimelerin ilk kelimesi küçük harfle başlar sonraki kelimelerin baş harfleri büyük olacak şekilde devam eder.

Örnek: string adSoyad = “Samet Gönez”;

            Hungarion Standardı
Yapı olarak Pascal gibidir. Sadece değişken isminin önüne tipini belirten ön ek eklenir.

Örnek:

bool için => bool bIsActive = true;

            Underscore Standardı
Yapı olarak Pascal’a benzer. Pascaldan farklı olarak kelimelerin arasında _ karakteri koyulur.

Örnek:
            string Yazilim_Uzmani = “Samet Gönez”;

            Upperscore Standardı
Tüm harfler büyük harfle yazılır ve kelimeler arasında _ karakteri kullanılır.Genellikle sabit olan değerler için kullanılır.

Örnek:

            double PI_SAYISI = 3.14;

            Bu yazımda değişken isimlendirmelerinde dikkat etmemiz gereken kurallardan ve isimlendirme standartlarından 
            bahsetmeye çalıştım.Bir sonraki yazımda C# (C Sharp)’ta Operatör türlerinden bahsediyorum. dilerseniz bu yazımı da okuyabilirsiniz.

    */
            #endregion
        }
    }
}
