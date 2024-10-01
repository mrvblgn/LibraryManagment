// (record) Kitap -> Id, Title, Description, PageSize, PublishDate, ISBN, Stok
// (record) Author -> Id, Name, Surname
// (class) Category -> Id, Name

// Kitaplar listesi oluşturunuz 
// Yazarlar listesi oluşturunuz
// Kategoriler listesi oluşturunuz

// Yazarları ekrana bastıran kodu yazınız
// Kitapları ekrana bastıran kodu yazınız
// Kategorileri ekrana bastıran kodu yazınız

// Kitapları sayfa sayısına göre filtreleyen kodu yazınız
// Kütüphanedeki tüm kitapların sayfa sayısı toplamını hesaplayan kodu yazınız.
// Kitap başlığına göre filtreleme işlemini yapınız
// Kitap ISBN numarasına göre ilgili kitabı getiriniz

// Kitaplar listesine yeni bir kitap ekleyip eklendikten sonra listeyi ekran çıktısı olarak veriniz. 
// (Verileri kullanıcıdan alınız)
// * Kitap eklerken id'si veya ISBN numarası daha önceki eklenen kitaplarda var ise
// benzersiz bir kitap girmeniz gerekmektedir yazısı çıksın

// Kullanıcı bir Id girdiği zaman o id'ye göre kitabı silen ve yeni listeyi ekrana basan kodu yazınız.

// Kullanıcıdan ilk başta id değeri alıp arama yaptıktan sonra eğer o id'ye ait bir kitap yoksa 
// "İlgili id'ye ait bir kitap bulunamadı" yazısı çıksın.
// * Güncellenecek olan değerler kullanıcıdan alınacak

// Kullanıcıdan bir kitap almasını isteyen kodu yazınız
// Eğer o kitap stokta varsa "kitap alındı" yazısı çıksın
// Bir tane varsa o kitap alınsın ve 0 olursa listeden silinsin

// Prime örnekler
// BookDetail adında bir record oluşturup şu değerler listelenecek:
// Kitap id, Kitap Başlığı, Kitap Açıklaması, Kitap Sayfa Sayısı, ISBN, Yazar Adı, Kategori Adı


// Kullanıcıdan PageIndex ve PageSize değerlerini alarak sayfalama desteği getiriniz.


using LibraryManagment.ConsoleUI.Service;

BookService bookService = new BookService();

bookService.GetAllDetailsByCategoryId(1);
















