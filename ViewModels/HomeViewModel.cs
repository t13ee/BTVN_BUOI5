using BTVN5.Models;

namespace BTVN5.ViewModels
{
    public class HomeViewModel
    {
        public List<Book> Books { get; set; }
        public List<CategoryCountViewModel> Categories { get; set; }
    }

    public class CategoryCountViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
