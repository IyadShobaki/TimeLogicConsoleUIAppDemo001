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

    ///////////  
    public static List<BlockedTimeSlotModel> GetBlockedTimeSlotsByBarberexample1(int barberId, DateOnly date)
    {
        List<BlockedTimeSlotModel> bookedByBarber = new List<BlockedTimeSlotModel>()
        {

            new BlockedTimeSlotModel()
            {
                StartTime = new TimeOnly(13, 00),
                EndTime = new TimeOnly(14, 00)
            },

            new BlockedTimeSlotModel()
            {
                StartTime = new TimeOnly(17, 00),
                EndTime = new TimeOnly(18, 30)
            }
        };
        return bookedByBarber;
    }
    public static List<BlockedTimeSlotModel> GetBlockedTimeSlotsByBarberexample2(int barberId, DateOnly date)
    {
        List<BlockedTimeSlotModel> bookedByBarber = new List<BlockedTimeSlotModel>()
        {

           new BlockedTimeSlotModel()
            {
                StartTime = new TimeOnly(12, 15),
                EndTime = new TimeOnly(12, 45)
            },
            new BlockedTimeSlotModel()
            {
                StartTime = new TimeOnly(17, 00),
                EndTime = new TimeOnly(18, 15)
            }
        };
        return bookedByBarber;
    }

    public static List<BlockedTimeSlotModel> GetBlockedTimeSlotsByBarberexample3(int barberId, DateOnly date)
    {
        List<BlockedTimeSlotModel> bookedByBarber = new List<BlockedTimeSlotModel>()
        {
             new BlockedTimeSlotModel()
            {
                StartTime = new TimeOnly(15, 00),
                EndTime = new TimeOnly(16, 00)
            }
        };
        return bookedByBarber;
    }

    public static List<BlockedTimeSlotModel> GetBlockedTimeSlotsByBarberexample4(int barberId, DateOnly date)
    {
        List<BlockedTimeSlotModel> bookedByBarber = new List<BlockedTimeSlotModel>()
        {

        };
        return bookedByBarber;
    }
}
