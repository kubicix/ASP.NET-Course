namespace basics.Models
{
    public class Repository{
        private static readonly List<Course> _courses = new List<Course>();

        static Repository(){
            _courses = new List<Course>(){
                new Course() {
                    Id =1,
                    Title="aspnet course",
                    Description="nice course",
                    Image="1.jpg",
                    Tags = new string[]{
                        "aspnet",
                        "web gelistirme"
                    },
                    isActive=true,
                    isHome=true
                },
                new Course() {
                    Id =2,
                    Title="php",
                    Description="nice course",
                    Image="3.jpg",
                    Tags = new string[]{
                        "php",
                        "web gelistirme"
                    },
                    isActive=true,
                    isHome=true
                },
                new Course() {
                    Id =3,
                    Title="django course",
                    Description="nice course",
                    Image="2.jpg",
                    isActive=true,
                    isHome=true
                },
                new Course() {
                    Id =4,
                    Title="Javascript course",
                    Description="nice course",
                    Image="3.jpg",
                    isActive=false,
                    isHome=true
                }
            };
        }

        public static List<Course> Courses{
            get{
                return _courses;
            }
        }

        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(c=> c.Id == id);
        }
    }
}