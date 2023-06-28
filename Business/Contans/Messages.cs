using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contans
{
	public static class Messages
	{
		public static string IdValueLessthanZeroError = "Id Değeri Sıfırdan Küçük Olamaz!";
		public static string CategoriesListed = "Kategoriler Listelendi!";
		public static string GivenValueCurrentError = "Verilen Değer Sistemde Mevcut";
		public static string CurrentValueInSystemError = "Güncellenmek istenen değer sistemde mevcut";
		public static string ValueError = "Bu Alan Boş Geçilemez!";
		public static string NullEntityError = "Boş Değer Gönderildi Hatası!";
		public static string ExistingEntityError = "Böyle bir değer bulunamadı!";
		public static string DeletedMessage = "Silme işlemi başarılı!";
		public static string GetAllData = "Tümü listelendi!";
		public static string ListIsEmpty = "Liste boş!";
		public static string UpdateData = "Güncelleme işlemi başarılı";
		public static string AddedData = "Ekleme İşlemi Başarılı";
	}
}
