namespace TimeLogicConsoleUI;

public static class TestData
{

    // Lunch time will be added as parameter to the list at the first time being called
    // For now its hard coded between 2 - 3
    public static List<AppointmentModel> BookedAppointmentsExample1()
    {
        List<AppointmentModel> bookedAppointments = new List<AppointmentModel>()
        {
            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(10, 00),
                AppointmentEndTime = new TimeOnly(10, 30)
            },
            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(10, 30),
                AppointmentEndTime = new TimeOnly(11, 00)
            },
            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(11, 45),
                AppointmentEndTime = new TimeOnly(12, 15)
            },

            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(15, 00),
                AppointmentEndTime = new TimeOnly(15, 30)
            },
            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(18, 15),
                AppointmentEndTime = new TimeOnly(18, 45)
            }
        };

        return bookedAppointments;
    }

    public static List<AppointmentModel> BookedAppointmentsExample2()
    {
        List<AppointmentModel> bookedAppointments = new List<AppointmentModel>()
        {
            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(10, 00),
                AppointmentEndTime = new TimeOnly(10, 30)
            },
            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(10, 30),
                AppointmentEndTime = new TimeOnly(11, 00)
            },
            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(11, 45),
                AppointmentEndTime = new TimeOnly(12, 15)
            },
            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(12, 45),
                AppointmentEndTime = new TimeOnly(13, 15)
            }

        };

        return bookedAppointments;
    }

    public static List<AppointmentModel> BookedAppointmentsExample3()
    {
        List<AppointmentModel> bookedAppointments = new List<AppointmentModel>()
        {

            new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(12, 45),
                AppointmentEndTime = new TimeOnly(13, 15)
            },
             new AppointmentModel()
            {
                AppointmentStartTime = new TimeOnly(16, 00),
                AppointmentEndTime = new TimeOnly(16, 30)
            }

        };
        return bookedAppointments;
    }

    public static List<AppointmentModel> BookedAppointmentsExample4()
    {
        List<AppointmentModel> bookedAppointments = new List<AppointmentModel>()
        {

        };
        return bookedAppointments;
    }
}
