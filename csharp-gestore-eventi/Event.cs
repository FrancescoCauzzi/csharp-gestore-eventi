﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Event
    {
        // private fields
        private DateTime _eventDate;

        private string ?_title;

        private int _eventCapacity;

        // Properties
        public string Title { get
            {
                return _title.ToString();
            }
            set { 
                if(!string.IsNullOrEmpty(value.Trim())) {
                    _title = value;
                }
                else
                {
                    throw new ArgumentException("The title must be inserted");
                }
            
            } }
        

        public DateTime EventDate
        {
            get
            {
                return _eventDate; // Getter simply returns the value of the private field
            }
            set
            {
                // Inside the set method, you can apply conditions
                if (value >= DateTime.Now) // For example, check if the new value is not in the past
                {
                    _eventDate = value; // Assign the new value to the private field
                }
                else
                {
                    // Optionally, you can throw an exception or take some other action if the condition is not met
                    throw new ArgumentException("Event date cannot be in the past.");
                }
            }
        }

        public int EventCapacity { get { 
            return _eventCapacity;
            }  set{
                if(value > 0)
                {
                    _eventCapacity = value;
                }else{
                    throw new ArgumentException("Capacity must be greater than 0");
                }
            }
        }

        public int ReservedSeats { get; private set; }

        // Constructor
        //Dichiarare un costruttore che prenda come parametri il titolo, la data e i posti a disposizione e inizializza gli opportuni attributi facendo uso dei metodi e controlli già fatti. Per l’attributo posti prenotati invece si occupa di inizializzarlo lui a 0.

        public Event(string _title, DateTime _eventDate, int _eventCapacity)
        {
            Title = _title;
            EventDate = _eventDate;
            EventCapacity = _eventCapacity;
            ReservedSeats = 0;
        }

        // Public Methods

        

    }
}