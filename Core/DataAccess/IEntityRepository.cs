
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    /*<T> yerine sınırlan dırmamız gerekecek Herkes T yerine istediğini yazabilir. Niye yazıyor lan Yazmasın.
     <T> yi filtreleme işlemni yapoacağız. (Generic Constraint ) Nasıl yapılır?
    
    public interface IEntityRepository<T> where T:class
    class burda bir referanstır class sınıfını belirtiuor gibisinden bişey değil.
    bizim amacımız sadece ve sadece entities concrete dweki classları yazabilmek
    ---> public interface IEntityRepository<T> where T:class,IEntity
     (IEntity tüm oluşturduğumuz classları implemente ediyor.)
    public interface IEntityRepository<T> where T:class,IEntity bu kod oluışturduğumuzIEntity de içine katmış oluruz.
    Bunu Engellemek için 
    public interface IEntityRepository<T> where T:class,IEntity,new() yazarsak sadece oşuşturduğumuz classları yazabiliriz
    ÇÜNKÜ IEntity BİR İMNTERFACE VE İNTERFACELER NEW LENEMEZ.

    CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ.
    CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ.
    CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ.

     */
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {

        //Expression: Belirli bir filtr vererek veiyi getirme
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


        /*
         *  T Get(Expression<Func<T, bool>> filter); bunu yazınca
        List<T> GetAllByBrand(int BrandId); //Ürünleri BrandId ye göre fitrele
        bunu yazmaya gerek kalmadı.
         
         */
        //Tüm classlar için oluşturulan Dal operasyonlarınmı burada toplayacağız.

    }
}
