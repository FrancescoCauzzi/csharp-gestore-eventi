using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// BONUSSS
namespace csharp_gestore_eventi
{
    public class Conferenza : Event
    {
        private string _presenter;
        private double _price;
        public string Presenter 
        {
            get
            {
                return _presenter;
            }
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    _presenter = value;
                }
                else
                {
                    throw new ArgumentException("Il nome del relatore deve essere inserito");
                }
            }
        }

        public double Price {
            get{
                return _price;
            }
            set{
                if(value < 0)
                {
                    throw new ArgumentException("Il prezzo deve essere positivo");
                }else{
                    _price = value;
                }
            }            
        }

        // Constructor
        public Conferenza(string name, DateTime date, int eventCapacity, string presenter, double price) : base(name, date, eventCapacity)
        {
            this._presenter = presenter;
            this._price = price;
        }

        // METHODS
        public string GetFormattedDate(){
            return this.EventDate.ToString("dd/MM/yyyy");
        }

        public string GetFormattedPrice(){
            return this.Price.ToString("0.00");
        
        }

        public override string ToString()
        {
            return $"{this.GetFormattedDate()} - {this.Title} -{this.Presenter} - {this.GetFormattedPrice}";
        }

    }
}
