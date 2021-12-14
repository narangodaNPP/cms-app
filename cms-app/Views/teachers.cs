using cms_app.Models;

namespace cms_app.Views
{
    internal class teachers : teacher
    {
        public object firstName { get; set; }
        public object lastName { get; set; }
        public object email { get; set; }
        public int contactNo { get; set; }
        public object password { get; set; }
        public object dateofbirth { get; set; }
    }
}