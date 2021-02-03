
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.MODEL.Entities
{
    public class Member : BaseEntity 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Ticket Ticket { get; set; }
        public MemberRoles Roles { get; set; }
        public Ticket FirstTicket { get; set; }

        public int? MemberDetailID { get; set; }




        public Member()
        {
            if (Ticket.TicketCount==1)
            {
                Ticket = FirstTicket;
            }            
            else if (DateTime.Now ==Ticket.SoldTime.AddMonths(1))
            {
                Ticket.TicketCount = 0;
            }
        }

        public void CalculatePrice() {
            

            if(Roles == MemberRoles.VIP)
            {
                if (Ticket== FirstTicket)
                {
                   Ticket.Price = Ticket.Price*(Ticket.TicketAmount-1);
                } 
                else if (Ticket.TicketAmount < 4)
                {
                   Ticket.Price = (Ticket.TicketAmount-1)* Ticket.Price * 0.80+(Ticket.Price*0.5);
                }
               else 
                {
                    Ticket.Price = Ticket.Price * 0.5;

                }
                    

            }
            else if(Roles == MemberRoles.Student)
            {
                Ticket.Price = Ticket.Price * 0.60;
            }
        }


        //relational properties
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public virtual MemberDetail MemberDetail { get; set; }



    }
    public enum MemberRoles
    {
        VIP,Student,Executive,Normal,BoxOffice,Owner
    }
}
