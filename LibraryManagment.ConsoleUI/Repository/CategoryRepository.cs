namespace LibraryManagment.ConsoleUI.Repository;

public class CategoryRepository
{
    List<Category> categories = new List<Category>()
    {
        new Category(1, "Dünya Klasikleri"),
        new Category(2, "Türk Klasikleri"),
        new Category(3, "Bilim Kurgu"),
    };
}