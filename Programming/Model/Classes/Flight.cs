using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о рейсе.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полета рейса в минутах.
        /// </summary>
        private int _flightTimeInMinutes;

        /// <summary>
        /// Создает экземпляр класса <<see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <<see cref="Flight"/>.
        /// </summary>
        /// <param name="flightTimeInMinutes">Время полета в минутах.</param>
        /// <param name="departure">Пункт вылета.</param>
        /// <param name="destination">Пункт назначения.</param>
        public Flight(int flightTimeInMinutes, string departure, string destination)
        {
            FlightTimeInMinutes = flightTimeInMinutes;
            Departure = departure;
            Destination = destination;
        }

        /// <summary>
        /// Возвращает и задает пункт вылета рейса.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задает пункт назначения рейса.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета рейса в минутах. Должно быть положительное.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }
    }
}
