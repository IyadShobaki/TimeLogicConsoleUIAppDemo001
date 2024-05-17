

using TimeLogicConsoleUI;




var bookedListExample = TestData.BookedAppointmentsExample1();
//var bookedListExample = TestData.BookedAppointmentsExample2();
//var bookedListExample = TestData.BookedAppointmentsExample3();
//var bookedListExample = TestData.BookedAppointmentsExample4();

var barberStartTime = new TimeOnly(10, 00);
var barberEndTime = new TimeOnly(19, 00);
var lunchStartTime = new TimeOnly(14, 00);
var lunchEndTime = new TimeOnly(15, 00);
var blockByBarberStartTime = new TimeOnly(16, 00);
var blockByBarberEndTime = new TimeOnly(19, 00);


Console.WriteLine("Booked Appointments: ");
foreach (var appointment in bookedListExample)
{
    Console.WriteLine($"{appointment.AppointmentStartTime} - {appointment.AppointmentEndTime}");
}

Console.WriteLine("==========================================");

Console.WriteLine("Available Appointments: ");
var availbleList = Logic.GetAvailableList(bookedListExample, 15,
                                            barberStartTime, barberEndTime,
                                            lunchStartTime, lunchEndTime,
                                             //blockByBarberStartTime, blockByBarberEndTime);
                                             null, null);
foreach (var appointment in availbleList)
{
    Console.WriteLine($"{appointment.AppointmentStartTime} - {appointment.AppointmentEndTime}");
}


Console.ReadLine();


