using InsiteTeamTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace InsiteTeamTask.Repositories.AttendanceRepo
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly MockDataService service;

        public AttendanceRepository()
        {
            service = new MockDataService();
        }

        public List<Attendance> GetAttendanceListByProductId(string productId)
        {
            List<Member> members = service.Members().Where(x => x.ProductId == productId).ToList();
            List<Ticket> tickets = service.Tickets().Where(x => x.ProductId == productId).ToList();
            List<Product> products = service.Products().Where(x => x.Id == productId).ToList();

            List<Attendance> attendanceList = new List<Attendance>();

            foreach (Member member in members)
            {
                attendanceList.Add(new Attendance()
                {
                    Barcode = "N/A",
                    MemberId = member.Id
                });
            }

            foreach (Ticket ticket in tickets)
            {
                attendanceList.Add(new Attendance()
                {
                    Barcode = ticket.Barcode,
                    MemberId = 0
                });
            }

            return attendanceList;
        }

        public List<Attendance> GetAttendanceListBySeasonId(int seasonId)
        {
            List<Product> products = service.Products().Where(x => x.SeasonId == seasonId).ToList();
            List<Member> members = service.Members().ToList();
            List<Ticket> tickets = service.Tickets().ToList();

            List<Member> seasonMembers = new List<Member>();
            List<Attendance> attendanceList = new List<Attendance>();

            foreach (Product product in products)
            {
                foreach (Member member in members)
                {
                    if (member.ProductId == product.Id)
                    {
                        attendanceList.Add(new Attendance()
                        {
                            Barcode = "N/A",
                            MemberId = member.Id
                        });
                    }
                }
            }

            foreach (Product product in products)
            {
                foreach (Ticket ticket in tickets)
                {
                    if (ticket.ProductId == product.Id)
                    {
                        attendanceList.Add(new Attendance()
                        {
                            Barcode = ticket.Barcode,
                            MemberId = 0
                        });
                    }
                }
            }


            return attendanceList;
        }

        public List<Attendance> GetAttendanceListByGameId(int gameId)
        {

            List<Product> products = service.Products().Where(x => x.GameId == gameId).ToList();
            List<Ticket> tickets = service.Tickets().ToList();

            List<Attendance> attendanceList = new List<Attendance>();

            foreach (Product product in products)
            {
                foreach (Ticket ticket in tickets)
                {
                    if (ticket.ProductId == product.Id)
                    {
                        attendanceList.Add(new Attendance()
                        {
                            Barcode = ticket.Barcode,
                            MemberId = 0
                        });
                    }
                }
            }


            return attendanceList;
        }

        public List<Attendance> GetAttendanceListBySeasonIdAndGameId(int seasonId, int gameId)
        {
            List<Ticket> tickets = service.Tickets().ToList();
            List<Product> products = service.Products().Where(x => x.SeasonId == seasonId)
                                                       .Where(x => x.GameId == gameId)
                                                       .ToList();

            List<Attendance> attendanceList = new List<Attendance>();

            foreach (Product product in products)
            {
                foreach (Ticket ticket in tickets)
                {
                    if (ticket.ProductId == product.Id)
                    {
                        attendanceList.Add(new Attendance()
                        {
                            Barcode = ticket.Barcode,
                            MemberId = 0
                        });
                    }
                }
            }

            return attendanceList;
        }
    }
}
