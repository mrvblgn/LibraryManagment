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


using LibraryManagment.ConsoleUI;
using LibraryManagment.ConsoleUI.Service;

// repository'de veri giriyoruz service'te çıktı dönüyoruz

BookService bookService = new BookService();
//bookService.GetAll();
bookService.GetAllDetailsByCategoryId(1);



//GetAllCategories();

// GetAllBooksByPageSizeFilter();
// PageSizeTotalCalculator();
// GetAllBooksByTitleContains();
// GetBookByISBN();
// AddBook();

/*void GetBookInputs(out int id,
    out string title,
    out string description,
    out int pageSize,
    out string publishDate,
    out string isbn)
{
    Console.WriteLine("Lütfen kitap id sini giriniz: ");
    id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
    description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
    pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
    publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
    isbn = Console.ReadLine();
}

Book GetBookInputs2(){
    Console.WriteLine("Lütfen kitap id sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    string title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
    string description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
    int pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
    string publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
    string isbn = Console.ReadLine();

    Book book = new Book(id, title, description, pageSize, publishDate, isbn);
    return book;
}

Author GetAuthorInputs()
{
    Console.WriteLine("Lütfen yazar id'sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Lütfen yazar adını: ");
    string name = Console.ReadLine();
    
    Console.WriteLine("Lütfen yazar soyadını giriniz: ");
    string surname = Console.ReadLine();
    
    Author author = new Author(id, name, surname);
    return author;
}

bool AddAuthorValidator(Author author)
{
    bool isValid = true;

    foreach (Author item in authors)
    {
        if (item.Id == author.Id || item.Name == author.Name || item.Surname == author.Surname)
        {
            isValid = false;
            break;
        }
    }

    return isValid;
}

Category GetCategoryInputs()
{
    Console.WriteLine("Lütfen kategori id sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Lütfen kategori adını giriniz: ");
    string name = Console.ReadLine();
    
    Category category = new Category(id, name);
    return category;
}

bool AddCategoryValidator(Category category)
{
    bool isUnique = true;

    foreach (Category item in categories)
    {
        if (item.Id == category.Id || item.Name == category.Name)
        {
            isUnique = false;
            break;
        }
    }
    return isUnique;
}

bool AddBookValidator(Book book)
{
    bool isUnique = true;

    foreach (Book item in books)
    {
        if (item.Id == book.Id || item.ISBN == book.ISBN)
        {
            isUnique = false;
            break;
        }
    }

    return isUnique;
}

void AddAuthor()
{
    Author author = GetAuthorInputs();

    bool isUnique = AddAuthorValidator(author);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz yazar benzersiz değil");
        return;
    }
    authors.Add(author);
    GetAllAuthors();
}

void AddCategory()
{
    Category category = GetCategoryInputs();
    
    bool isUnique = AddCategoryValidator(category);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz kategori benzer değil");
        return;
    }

    categories.Add(category);
    GetAllCategories();
}

void PageSizeTotalCalculator()
{
    int toplam = 0;
    foreach (Book book in books)
    {
        int sayfaSayisi = book.PageSize;
        toplam += sayfaSayisi;
    }

    Console.WriteLine("Toplam sayfa sayısı: " + toplam);
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
}*/













