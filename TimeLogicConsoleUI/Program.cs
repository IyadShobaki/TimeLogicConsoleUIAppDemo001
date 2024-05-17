

using TimeLogicConsoleUI;




var bookedListExample = TestData.BookedAppointmentsExample1();
//var bookedListExample = TestData.BookedAppointmentsExample2();
//var bookedListExample = TestData.BookedAppointmentsExample3();

Console.WriteLine("Booked Appointments: ");
foreach (var appointment in bookedListExample)
{
    Console.WriteLine($"{appointment.AppointmentStartTime} - {appointment.AppointmentEndTime}");
}

Console.WriteLine("==========================================");

Console.WriteLine("Available Appointments: ");
var availbleList = Logic.GetAvailableList(bookedListExample, 30);
foreach (var appointment in availbleList)
{
    Console.WriteLine($"{appointment.AppointmentStartTime} - {appointment.AppointmentEndTime}");
}


Console.ReadLine();


