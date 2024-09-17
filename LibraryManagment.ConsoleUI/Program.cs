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
//GetAllBooks();

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
//GetAllAuthors();

List<Category> categories = new List<Category>()
{
    new Category(1, "Dünya Klasikleri"),
    new Category(2, "Türk Klasikleri"),
    new Category(3, "Bilim Kurgu"),
};
//GetAllCategories();

// GetAllBooksByPageSizeFilter();
// PageSizeTotalCalculator();
// GetAllBooksByTitleContains();
// GetBookByISBN();
// AddBook();
AddAuthor();
AddCategory();

void GetBookInputs(out int id,
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

void AddBook()
{
    //1. Yöntem
    //int id;
    //string title;
    //string description;
    //int pageSize;
    //string publishDate;
    //string isbn;

    //GetBookInputs(out id,out title,out description,out pageSize,out publishDate,out isbn);
    Book book = GetBookInputs2();

    bool isUnique = AddBookValidator(book);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz kitap Benzersiz değil.");
        return;
    }
    books.Add(book);
    GetAllBooks();
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

void GetBookByISBN()
{
    Console.WriteLine("Lütfen ISBN numarasını giriniz: ");
    string isbn = Console.ReadLine();
    
    foreach (Book book in books)
    {
        if (book.ISBN == isbn)
        {
            Console.WriteLine(book);
        }
    }
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

void GetAllBooksByTitleContains()
{
    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    string arama = Console.ReadLine();

    foreach (Book book in books)
    {
        if(book.Title.Contains(arama, StringComparison.CurrentCultureIgnoreCase))
        {
            Console.WriteLine(book);
        }
    }
}

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

void GetAllBooksByPageSizeFilter()
{
    PrintAyirac("Sayfa sayısına göre filtreleme");
    
    Console.WriteLine("Lütfen min değeri giriniz: ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen max değeri giriniz: ");
    int max = Convert.ToInt32(Console.ReadLine());

    foreach (Book item in books)
    {
        if (item.PageSize <= max && item.PageSize >= min)
        {
            Console.WriteLine(item);
        }
    }
}












