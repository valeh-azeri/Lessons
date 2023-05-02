using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomerBase());
        }
        /*
            Homework 1:
            Bir dənə müştəri bazası proqramı yığacaqsınız. Müştəri məlumatları belə olacaq: 
            Ad, Soyad, Cinsiyyət, Ölkə, Şəhər, Ünvan, Telefon, Email. VirtualDatabase'də
            hazır 5-6 müştəriniz olsun və app açılanda user dropdown içindən müştərini seçəndə 
            müştəri məlumatları textbox'lara yazılsın. TextBox'ların altında yadda saxla
            button'u olacaq və o button'a click edəndə müştərinin məlumatları VirtualDatabase'dəki
            List'də update olacaq. Bir dənə də qırmızı delete button'u olacaq və o
            button'a click edəndə müştərinin məlumatlarının silinib silinməməsi barədə bildiriş çıxacaq 
            ("Müştərini silmək istədiyinizdən əminsiniz mi?") və adam Yes seçsə
            həmin müştərini List'dən siləcəksiz No və ya Cancel seçsə heçnə etməyəcəksiniz. 
            Birdə Yeni Müştəri əlavə et button'u olacaq və ona da click edəndə ayrı bir form
            pəncərəsi açılacaq və müştərinin məlumatlarını doldurub əlavə et button'una click
            edəndə yeni əlavə olunan müştəri  məlumatları VirtualDatabase'dəki List'ə əlavə
            olunacaq və form bağlanacaq. Yeni əlavə olunan müştərini dropdown'a da əlavə etməyi unutmayın. 
            Ölkə və şəhər'i ilkin olaraq string olaraq edin. Taskı erkən
            bitirsəz ondan sonra Ölkə və Şəhər bölməsini də dropdown ilə etməyə çalışın.
            */
        /*
        Homework1:
        Bir Memory Game yığmalısınız. Məsələn 20 dənə button olacaq və button'ların rəngi oyun başlayanda boz olacaq. 
        Button'ların hər birində bir şəkil gizlənəcək. Button'a click edən zaman həmin button'un şəkli o button'un 
        arxa fonu olacaq. Eyni anda 2 button'un arxa fon şəkli görsənəcək və 3-cü button'a click edəndə digər 2 button 
        təkrar boz olacaq və 3-cü click edilən button'un arxa fonunda öz şəkli çıxacaq. Ancaq 3-cü button'a click edəndə
        əgər ondan əvvəlki 2 button'un arxa fon şəkli eyni olubsa bağlanmayacaq onlar açıq qalacaq və 4-cü button'a click 2
        edəndə 3 və 4'ün şəkilləri fərqlidirsə 5-ci button'a click edəndə 3 və 4 boz olacaq 5 açılacaq. Ümumi 10 ədəd şəkil 
        lazımdır 20 button üçün çünkü 1 şəkil 2 button'da gizlənəcək. Google'da Memory Game yazıb nümunələrinə baxa bilərsiniz. 
        Reset Game button'u olacaq və click olunan zaman şəkillərin yerləri random dəyişdirilib 
        button'lar yenidən boz olacaq. Oyun bitəndə isə ilk açılan buttonla son button arasında yəni oyun müddətində keçən zaman 
        bir label'ə yazılacaq.  Oyun ilk dəfə run olunanda "Rekord: -" yazılacaq. İlk oyunda əgər 40 saniyəyə bitirmişəmsə 
        "Rekord: 00:40:00.000" yazılacaq (millisaniyələr də nəzərə alınır). Növbəti oyunların birində əgər 40 saniyə rekordum 
        qırılarsa onda ekrana "Rekord yeniləndi!" popup mesajı çıxacaq. Əgər rekord yenilənməzsə
        oyun bitəndə "Uduzdunuz!" mesajı çıxacaq. Oyun resetlənən zaman rekord dəyəri sıfırlanmayacaq sadəcə button'lar 
        sıfırlanacaq.
        */
    }
}
