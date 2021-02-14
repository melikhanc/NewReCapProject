using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.DTOs
{
    public class CarDetailDto:IDto
    {




        /*
         
         car Tablosunda arabaların markaları yok. brand tablosunda yer alıyor (BrandName)

        bu tip join gibi operasyonları DTO da yazarız (Data Transformation Object)
         
         */

        /*CarDetailDto:IDto yazdık IDto diye bir interface mevcut değil
         o yüzden IDto nun üzerine gel, ampülü gör, Generate type IDto -> Generate new type*/

        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }


    }
}
