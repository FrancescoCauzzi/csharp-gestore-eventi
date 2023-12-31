﻿using static System.Console;
namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            while(true){
                try{
                    int reservedSeats = InputChecker.GetIntInput();
                    primoEvento.AddReservedSeats(reservedSeats);
                    break;
                }
                catch(Exception ex)
                {
                    WriteLine(ex.Message);
                    Write("Inserisci di nuovo il numero di posti desideri prenotare: ");
                    
                }
            }

            
            primoEvento.PrintReservedSeatsAndAvailableSeats();
            WriteLine();
            Write("Vuoi disdire dei posti? ");
            string answer = InputChecker.GetStringInput();
            if(InputChecker.IsStringYes(answer))
            {
                Write("Quanti posti vuoi disdire? ");

                while(true){
                    try{
                        int cancelledSeats = InputChecker.GetIntInput();
                        primoEvento.RemoveReservedSeats(cancelledSeats); 
                        break;
                    }
                    catch(Exception ex)
                    {
                        WriteLine(ex.Message);
                        Write("Inserisci di nuovo il numero di posti che desideri disdire: ");
                        
                    }
                }                

                primoEvento.PrintReservedSeatsAndAvailableSeats();
            }else{
                WriteLine("Ok, va bene");                
                primoEvento.PrintReservedSeatsAndAvailableSeats();
            }
            */
            // MILESTONE 4


            Write("Inserisci il nome del tuo programma Eventi: ");
            string programName = InputChecker.GetStringInput();
            ProgrammaEventi newProgram = new ProgrammaEventi(programName);

            WriteLine();
            Write("Indica il numero di eventi da inserire: ");
            int? programNumber = InputChecker.GetIntInput();
            WriteLine();

            for (int i = 1; i <= programNumber; i++)
            {
                while (true)
                {
                    try
                    {
                        Write($"Inserisci il nome del {i}° evento: ");
                        string eventTitle = InputChecker.GetStringInput();
                        Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
                        DateTime eventDate = InputChecker.GetDateTimeInput();
                        Write("Inserisci il numero di posti totali: ");
                        int totalSeats = InputChecker.GetIntInput();

                        Event nuovoEvento = new Event(eventTitle, eventDate, totalSeats);
                        newProgram.AddEvent(nuovoEvento);
                        break;
                    }
                    catch (Exception ex)
                    {
                        WriteLine(ex.Message);
                        WriteLine($"Inserisci i dati del {i}° evento nuovamente");
                    }
                }
            }
            WriteLine();
            WriteLine("Il numero di eventi nel programma é: " + newProgram.GetEventsNumber());

            WriteLine(newProgram.GetEventProgramInfo());
            WriteLine();
            Write($"Inserisci una data per sapere che eventi ci saranno il (gg/mm/yyyy): ");
            DateTime dateToCheck = InputChecker.GetDateTimeInput();
            List<Event> eventsByDate = newProgram.GetEventsByDate(dateToCheck);
            ProgrammaEventi.PrintEventList(eventsByDate);
            // Eliminate tutti gli eventi dal vostro programma.
            // newProgram.EmptyEventList();
            WriteLine();



            // BONUS
            WriteLine("Aggiungiamo anche una conferenza");
            while (true)
            {
                try
                {
                    Write($"Inserisci il nome della conferenza: ");
                    string confereceTitle = InputChecker.GetStringInput();
                    Write("Inserisci la data della conferenza (gg/mm/yyyy): ");
                    DateTime confereceDate = InputChecker.GetDateTimeInput();
                    Write("Inserisci il numero di posti per la conferenza: ");
                    int totalSeats = InputChecker.GetIntInput();
                    Write("Inserisci il relatore della conferenza: ");
                    string conferenceRelator = InputChecker.GetStringInput();
                    Write("Inserisci il prezzo del biglietto della conferenza: ");
                    double conferecePrice = InputChecker.GetDoubleInput();
                    Conferenza nuovaConferenza = new Conferenza(confereceTitle, confereceDate, totalSeats, conferenceRelator, conferecePrice);
                    newProgram.AddEvent(nuovaConferenza);
                    break;
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                    WriteLine($"Inserisci i dati della conferenza nuovamente");
                }
            }
            WriteLine();
            WriteLine("Ecco il tuo programma eventi anche con le Conferenze:");
            WriteLine(newProgram.GetEventProgramInfo());

            ReadKey();












        }
    }



}


