using Business.Abstract;
using DataAccess.Concrate;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class HotelManager : IHotelService
    {
        private HotelRepository _hotelRepository;
        public HotelManager()
        {
            _hotelRepository = new HotelRepository();

        }

        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            if (id > 0)
            {
                return _hotelRepository.GetHotelById(id);
            }
            throw new Exception("id can not be less or 1");

        }

        public Hotel UpdateHotel(Hotel hotel)
        {
             return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
