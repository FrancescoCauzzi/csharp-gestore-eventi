using static System.Console;
namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Inserisci il nome dell'evento: ");
            string eventName = InputChecker.GetStringInput();
            Write("Inserisci la data dell'evento: ");
            DateTime eventDate = InputChecker.GetDateTimeInput();            
            Write("Inserisci il numero di posti totali: ");
            int totalSeats = InputChecker.GetIntInput();

            // istanziare un evento
            Event primoEvento = new Event(eventName, eventDate, totalSeats);
            // Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni vuole fare e provare ad effettuarle.
            WriteLine();
            Write("Quanti posti desideri prenotare? ");
            int reservedSeats = InputChecker.GetIntInput();
            while(true){
                try{
                    primoEvento.AddReservedSeats(reservedSeats);
                    break;
                }
                catch(Exception ex)
                {
                    WriteLine(ex.Message);
                    Write("Inserisci di nuovo il numero di posti desideri prenotare: ");
                    reservedSeats = InputChecker.GetIntInput();
                }
            }

            
            primoEvento.PrintReservedSeatsAndAvailableSeats();
            WriteLine();
            Write("Vuoi disdire dei posti? ");
            string answer = InputChecker.GetStringInput();
            if(InputChecker.IsStringYes(answer))
            {
                Write("Quanti posti vuoi disdire? ");
                int cancelledSeats = InputChecker.GetIntInput();

                while(true){
                    try{
                        primoEvento.RemoveReservedSeats(cancelledSeats); 
                        break;
                    }
                    catch(Exception ex)
                    {
                    WriteLine(ex.Message);
                    Write("Inserisci di nuovo il numero di posti che desideri disdire: ");
                    cancelledSeats = InputChecker.GetIntInput();
                    }
                }                

                primoEvento.PrintReservedSeatsAndAvailableSeats();
            }else{
                WriteLine("Ok, va bene");                
                primoEvento.PrintReservedSeatsAndAvailableSeats();
            }
        }
    }
            

    
}


                    