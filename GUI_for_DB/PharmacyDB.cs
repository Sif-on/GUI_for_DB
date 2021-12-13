using System;
using System.Data.Entity;
using System.Linq;

namespace GUI_for_DB
{
    public class PharmacyDB : DbContext
    {
        // Контекст настроен для использования строки подключения "PharmacyDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "GUI_for_DB.PharmacyDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "PharmacyDB" 
        // в файле конфигурации приложения.
        public PharmacyDB()
            : base("name=PharmacyDBEntities")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}