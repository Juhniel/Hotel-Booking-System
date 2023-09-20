using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;
using Hotel_Booking_System.Dto;

namespace Hotel_Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public BookingController(IBookingRepository bookingRepository, IUserRepository userRepository, IMapper mapper)
        {
            _bookingRepository=bookingRepository;
            _userRepository=userRepository;
            _mapper=mapper;
        }

        [HttpGet("bookings")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Booking>))]
        public IActionResult GetBookings()
        {
            var bookings = _mapper.Map<List<BookingDto>>(_bookingRepository.GetBookings());
            return Ok(bookings);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(BookingDto))]
        [ProducesResponseType(400)]
        public IActionResult GetBooking(int id)
        {
            if (!_bookingRepository.BookingExists(id))
                return NotFound();

            var booking = _mapper.Map<BookingDto>(_bookingRepository.GetBooking(id));
            return Ok(booking);
        }

        [HttpGet("{user}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Booking>))]
        [ProducesResponseType(400)]
        public IActionResult GetBookingsByUser(int userId)
        {
            if(!_userRepository.UserExists(userId))
                return NotFound();

            var bookings = _mapper.Map<List<BookingDto>>(_bookingRepository.GetBookingsByUserId(userId));
            return Ok(bookings);
        }
        [HttpGet("email/{email}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<BookingDto>))]
        [ProducesResponseType(404)]
        public IActionResult GetBookingsByEmail(string email)
        {
            var user = _userRepository.GetUserByEmail(email);
            if (user == null)
                return NotFound();

            var bookings = _mapper.Map<List<BookingDto>>(_bookingRepository.GetBookingsByEmail(email));
            return Ok(bookings);
        }
    }
}

