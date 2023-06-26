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
	}
}
