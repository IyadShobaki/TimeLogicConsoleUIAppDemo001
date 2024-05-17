namespace TimeLogicConsoleUI;

public class Logic
{


    public static List<AppointmentModel> GetAvailableList(List<AppointmentModel> bookedList, int serviceDuration)
    {


        var barberStartTime = new TimeOnly(10, 00);
        var barberEndTime = new TimeOnly(19, 00);


        int bookedListAppNumber = bookedList.Count;

        var availableList = new List<AppointmentModel>();


        availableList = AvailableBetweenBarberStartAndBooked(barberStartTime, bookedList[0].AppointmentStartTime,
                                    serviceDuration, availableList);

        int i = 0;
        do
        {
            int serviceDurationTemp = serviceDuration;
            AppointmentModel appointment;

            int intervalTimeBetween = GetIntervalTime(bookedList[i].AppointmentEndTime, bookedList[i + 1].AppointmentStartTime);
            // if the number is greater than the service time
            // find how many appointment can fit 
            int temp = 0;
            while (serviceDurationTemp <= intervalTimeBetween)
            {
                appointment = new AppointmentModel();

                appointment.AppointmentStartTime = bookedList[i].AppointmentEndTime.AddMinutes(serviceDuration * temp);
                appointment.AppointmentEndTime = bookedList[i].AppointmentEndTime.AddMinutes(serviceDurationTemp);

                availableList.Add(appointment);
                serviceDurationTemp += serviceDuration;
                temp++;
            }


            i++;

        } while (i < bookedListAppNumber - 1);

        availableList = AvailableBetweenBarberStartAndBooked(bookedList[bookedList.Count - 1].AppointmentStartTime, barberEndTime,
                                    serviceDuration, availableList);


        return availableList;
    }

    public static List<AppointmentModel> AvailableBetweenBarberStartAndBooked(TimeOnly startTime, TimeOnly endTime,
                                    int serviceDuration, List<AppointmentModel> resultList)
    {

        int serviceDurationTemp = serviceDuration;

        AppointmentModel appointment;

        int intervalTimeBetween = GetIntervalTime(startTime, endTime);
        // if the number is greater than the service time
        // find how many appointment can fit 
        while (serviceDurationTemp <= intervalTimeBetween)
        {
            appointment = new AppointmentModel();
            appointment.AppointmentStartTime = startTime;
            appointment.AppointmentEndTime = startTime.AddMinutes(serviceDuration);

            resultList.Add(appointment);
            serviceDurationTemp += serviceDuration;

        }
        return resultList;

    }

    public static int GetIntervalTime(TimeOnly firstTime, TimeOnly secondTime)
    {

        DateTime startTime = Convert.ToDateTime(firstTime.ToString());
        DateTime finishTime = Convert.ToDateTime(secondTime.ToString());

        TimeSpan startToFinishTimeSpan = finishTime - startTime;
        int intervalTime = (int)startToFinishTimeSpan.TotalMinutes;
        // Console.WriteLine($"Interval Time: {intervalTime}");
        return intervalTime;
    }


}
