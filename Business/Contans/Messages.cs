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
		public static string CarAdded = "Araç Eklendi!";
		public static string UnabletoAddVehicle = "Araç Eklenemedi!";
		public static string NoVehiclestoList = "Listelenecek Araç Yok";
		public static string IdValueLessthanZeroError = "Id Değeri Sıfırdan Küçük Olamaz!";
		public static string CarListed = "Araçlar Listelendi!";
		public static string CarDeleted = "Araç Silindi!";
		public static string CategoriesListed = "Kategoriler Listelendi!";
		public static string CarUpdated = "Araç Güncellendi!";
		public static string ColorListed = "Renkler Listelendi!";
		public static string ColorAdded = "Renk Eklendi";
		public static string ColorDeleted = "Renk Silindi";
		public static string ColorUpdated = "Renk Güncellendi!";
		public static string GivenValueCurrentError = "Verilen Renk Sistemde Mevcut";
		public static string CurrentValueInSystemError = "Güncellenmek istenen değer sistemde mevcut";
		public static string FuelTypeAdded = "Yakıt Türü Eklendi!";
		public static string ValueError = "Bu Alan Boş Geçilemez!";
		public static string NullEntityError = "Boş Değer Gönderildi Hatası!";
		public static string ExistingEntityError = "Silinecek Değer Bulunamadı!";
		public static string DeletedMessage = "Silme işlemi başarılı!";
		public static string GetAllData = "Tümü listelendi!";
		public static string ListIsEmpty = "Liste boş!";
		public static string UpdateData = "Güncelleme işlemi başarılı";
		public static string AddedData = "Ekleme İşlemi Başarılı";
	}
}
