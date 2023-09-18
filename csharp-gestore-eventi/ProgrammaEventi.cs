using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        // public Properties
        public string Title { get; set; }
        public List<Event> Events { get; set; }

        // Constructor
        // Nel costruttore valorizzare il titolo, passato come parametro, e inizializzate la lista di eventi come una nuova Lista vuota di eventi.
        public ProgrammaEventi(string title)
        {
            Title = title;
            Events = new List<Event>();
        }

        // METHODS !!!!!

        // AggiungiEvento: un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo.

        public void AddEvent(Event evento)
        {
            this.Events.Add(evento);
            WriteLine("Evento aggiunto correttamente");
        
        }

        // GetEventsByDate: un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.

        public List<Event> GetEventsByDate(DateTime date)
        {
            List<Event> eventsByDate = new List<Event>();
            foreach (Event _event in this.Events)
            {
                if (_event.EventDate == date)
                {
                    eventsByDate.Add(_event);
                }
            } 
            
            return eventsByDate;
        }

        // un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.
        public static void PrintEventList(List<Event> events)
        {    
            if(events.Count > 0){
                foreach(Event _event in events)
                {
                    WriteLine($"{_event}");
                }            
            }else{
                WriteLine("Non ci sono eventi da visualizzare");
            }       
        }

        // un metodo che restituisce quanti eventi sono presenti nel programma eventi attualmente.
        public int GetEventsNumber(){
            return this.Events.Count;        
        }

        // un metodo che svuota la lista di eventi.

        public void EmptyEventList(){
            this.Events.Clear();
            WriteLine("La lista di eventi è stata svuotata");        
        }

        // un metodo che restituisce una stringa che mostra il titolo del programma e tutti glieventi aggiunti alla lista.

        public string GetEventProgramInfo(){
            string myString = $"Ecco il tuo programma eventi:\n{this.Title}\n";
            foreach (Event _event in this.Events)
            {
                myString += $"{_event}\n";          
            }
            return myString;           

        }




        
        
        
        


    }
}
