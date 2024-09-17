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
// Kitap başlığına göre filtreleme işkemini yapınız
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


using LibraryManagment.ConsoleUI;

List<Book> books = new List<Book>()
{
    new Book(1, "Germinal", "Kömür Madeni", 341, "2012 Mayıs", "9789750723322"),
    new Book(2, "Suç ve Ceza", "Raskolnikov'un hayatı", 315, "2010 Haziran", "9789750723323"),
    new Book(3, "Kumarbaz", "Bir öğretmenin hayatı", 210, "2009 Ocak", "9789750723323"),
    new Book(4, "Araba Sevdası", "Arabayla alakası olmayan kitap", 400, "1999 Ocak", "9789750723324"),
    new Book(5, "Ateşten Gömlek", "Kurtuluş savaşını anlatan kitap", 320, "2001 Eylül", "9789750723325"),
    new Book(6, "Kaşağı", "Okunmaması gereken bir kitap", 95, "1993 Ocak", "9789750723326"),
    new Book(7, "Harry Potter ve Felsefe Taşı", "Harry felsefe taşını kurtarmaya çalışır", 540, "2000 Ocak", "9789750723327"),
    new Book(8, "16 Yıl Şampiyonluk", "Hayal ürünüdür", 255, "10 Eylül", "9789750723328"),
    new Book(9, "Rezonans Kanunu", "Kişisel gelişim kitabı", 320, "Kasım 2016", "9789750723329")
};
GetAllBooks();

List<Author> authors = new List<Author>()
{
    new Author(1, "Emile", "Zola"),
    new Author(2, "Fyodor", "Dostoyevski"),
    new Author(3, "Recaizade Mahmut", "Ekrem"),
    new Author(4, "Halide Edib", "Adıvar"),
    new Author(5, "Ömer", "Seyfettin"),
    new Author(6, "ALi", "Koç"),
    new Author(7, "Vız vız", "Ali")
};
GetAllAuthors();

List<Category> categories = new List<Category>()
{
    new Category(1, "Dünya Klasikleri"),
    new Category(2, "Türk Klasikleri"),
    new Category(3, "Bilim Kurgu"),
};
GetAllCategories();


void GetAllBooks()
{
    PrintAyirac("Kİtapları Listele: ");
    foreach (Book item in books)
        Console.WriteLine(item);
}

void GetAllAuthors()
{
    PrintAyirac("Yazarları Listele: ");
    foreach (Author item in authors)
        Console.WriteLine(item);

}

void GetAllCategories()
{
    PrintAyirac("Kategoriileri Listele: ");
    foreach (Category item in categories)
        Console.WriteLine(item);
}

void PrintAyirac(string veri)
{
    Console.WriteLine("------------------------------------------");
    Console.WriteLine(veri);
}












