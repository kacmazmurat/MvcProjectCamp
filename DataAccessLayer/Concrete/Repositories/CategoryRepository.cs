using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal 
      // : ifadesini koyduk demek ki burada birşeyi kalıtsal yollarla alacağız.
                                                  
      // Neyi alacağız ICategoryDal'ı alacağız.
                                                   
      // ICategory bizim interfacesimiz'di. Altını çizdi ctrl nokta yaptık 
                                                  
      //Using.DataAccessLayer.Abstract a tıklıyoruz yukarı using kodu geliyor.
                                                   
      //Tekrar altını çizdi. Sen burada CategoryRepostory sınıfının içerisine bir interface e ait bileşenleri almak istiyorsun ama interface e ait bileşenleri alacaksan eğer bu interface de yer alan metotları bu sınıfın içine implement etmen gerekiyor yoksa bunu kullanmazsın. Okey diyoruz üzerine geliyoruz ImplementInterface e tıklıyoruz.
                                                  
      //Implement Interface dediğimiz zaman metodlar otomatik olarak oluşuyor ekrana geliyor.
                                                   
       //Şimdi tek tek metotların içerisine ilgili ifadeleri yazmamız gerekiyor.
    {
        
        //Çağırmamız gereken iki ifade var context sınıfı bir de _object adında bir nesne lazım.
        //Context sınıfında değerleri DbSet türünüde tutmuştuk aynı şekilde burada da DbSet yazıyoruz.
        //Hata verecek Using.System.Data.Entity i tıklıyoruz. Dbset e ait entity ifadesi  dizine geliyor.
        
        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);  //Parametreden gelen değeri _object içerisinde bululnann sınıfa yani Category'e ekle
            c.SaveChanges(); 
        }

        public List<Category> List()
        {

            return _object.ToList();   //_objectten gelen ifadeyi ToList metodu ile listele 
            //To list entityframework da verileri listelemek için kullanılan metot. Onun dışındaki diğer ifadeler 
            //Add, remove, tolist,find metodları kullanılıyor.
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
