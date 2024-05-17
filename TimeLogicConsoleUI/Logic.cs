namespace TimeLogicConsoleUI;

public class Logic
{


    public static List<AppointmentModel> GetAvailableList(List<AppointmentModel> bookedList, int serviceDuration,
                                            TimeOnly barberStartTime,
                                            TimeOnly barberEndTime,
                                            TimeOnly lunchStartTime,
                                            TimeOnly lunchEndTime,
                                            TimeOnly? blockByBarberStartTime,
                                            TimeOnly? blockByBarberEndTime)
    {

        // Added fakely (not from the DB, so the logic can skip it)
        bookedList.Add(new AppointmentModel
        {

            AppointmentStartTime = lunchStartTime,
            AppointmentEndTime = lunchEndTime
        });

        // Added fakely (not from the DB, so the logic can skip it)
        if (blockByBarberStartTime != null && blockByBarberEndTime != null)
        {
            bookedList.Add(new AppointmentModel
            {
                AppointmentStartTime = (TimeOnly)blockByBarberStartTime,
                AppointmentEndTime = (TimeOnly)blockByBarberEndTime
            });
        }

        bookedList.Sort((x, y) => x.AppointmentStartTime.CompareTo(y.AppointmentStartTime));

        int bookedListAppNumber = bookedList.Count;

        var availableList = new List<AppointmentModel>();

        if (bookedList.Count > 1)
        {

            availableList = AvailableBetweenBarberStartAndBooked(barberStartTime, bookedList[0].AppointmentStartTime,
                                        serviceDuration, availableList);

            int i = 0;
            do
            {
                availableList = AvailableBetweenBarberStartAndBooked(bookedList[i].AppointmentEndTime,
                                        bookedList[i + 1].AppointmentStartTime, serviceDuration, availableList);
                i++;

            } while (i < bookedListAppNumber - 1);

            availableList = AvailableBetweenBarberStartAndBooked(bookedList[bookedList.Count - 1].AppointmentEndTime, barberEndTime,
                                        serviceDuration, availableList);
        }
        else
        {

            availableList = AvailableBetweenBarberStartAndBooked(barberStartTime, lunchStartTime,
                                        serviceDuration, availableList);
            // Lunch time is not stored in the db as an appointment 
            // It will not check the bookedList for lunch time
            // it will just skip it
            availableList = AvailableBetweenBarberStartAndBooked(lunchEndTime, barberEndTime,
                                       serviceDuration, availableList);
        }

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
        int temp = 0;
        while (serviceDurationTemp <= intervalTimeBetween)
        {
            appointment = new AppointmentModel();
            appointment.AppointmentStartTime = startTime.AddMinutes(serviceDuration * temp);
            appointment.AppointmentEndTime = startTime.AddMinutes(serviceDurationTemp);

            resultList.Add(appointment);
            serviceDurationTemp += serviceDuration;
            temp++;

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
