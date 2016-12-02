using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    // Claim For Josiah's Class
    public class VehicleElevator : ParkALot
    {
        LicensePlateRecognition licensePlate = new LicensePlateRecognition();
        RegisteredCustomer registeredCustomer = new RegisteredCustomer();
        CustomerInfo customerInfo = new CustomerInfo();

        public void ElevatorLift()
        {
            // determining if they are a registered customer or member
            try
            {
                // checking if they have a license plate
                if (licensePlate != null)
                {
                    // checking if the license plater number found belongs to a registered customer
                    // or to a member
                    if (licensePlate = customerInfo.licensePlate)
                    {
                        // then checking if they have a reservation at this time
                        if (customerInfo.id = registeredCustomer.reservation)
                        {
                            // succeeded, and they are a customer with a reservation and a license plate
                            // tied to their account. so the elevator will lift
                        }
                        else
                        {
                            // if the customer doesnt have a reservation for this time, then it will ask for
                            // their id and their parking duration to find available spots
                        }
                    }
                    else
                    {
                        // if the license plate found does not match with any customers in customerInfo
                        // then the display will ask for id 
                        string rawID = String.Empty;

                        Console.ReadLine();
                        rawID = Console.ReadLine();

                        if (rawID = customerInfo.id)
                        {
                            // then it will check for a reservation for this time
                            if (customerInfo.id = registeredCustomer.reservation)
                            {
                                // the customer has a reservation but the car isnt recognized to it will be 
                                // listed in the past reservations as a temporary license plate
                                // and then the elevator will lift
                            }
                            else
                            {
                                // if they didnt have a reservation, then they will be asked for the parking duration 
                                // and if they have availabilty then they can go up
                                if()
                                {
                                    // then if this is executed it means there is availability for 
                                    // a parking spot during that duration 
                                    // so the elevator will lift
                                }
                                else
                                {
                                    // there is no availability for a parking spot during that duration, so
                                    // the customer is asked to get off the elevator and search the ground level
                                    // for a parking spot
                                    // if they dont get off, then after a set amount of time, the system will alert
                                    // security
                                    licensePlate.ElevatorOccupancy();

                                    bool value = licensePlate.ElevatorOccupancy();

                                    if(value == true)
                                    {
                                        // then there is somebody there, and security will be called
                                        // maybe adding a silent timer so they will have time to leave
                                    }
                                    else
                                    {
                                        // now there is no occupancy, and it will go back to normal
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // this is for when there is no license plate, but it asks for the id anyways
                    string rawID = String.Empty;

                    Console.ReadLine();
                    rawID = Console.ReadLine();

                    if (rawID = customerInfo.id)
                    {
                        // then it will check for a reservation for this time
                        if (customerInfo.id = registeredCustomer.reservation)
                        {
                            // the customer has a reservation
                            // and then the elevator will lift
                        }
                        else
                        {
                            // if they didnt have a reservation, then they will be asked for the parking duration 
                            // and if they have availabilty then they can go up
                            if ()
                            {
                                // then if this is executed it means there is availability for 
                                // a parking spot during that duration 
                                // so the elevator will lift
                            }
                            else
                            {
                                // there is no availability for a parking spot during that duration, so
                                // the customer is asked to get off the elevator and search the ground level
                                // for a parking spot
                                // if they dont get off, then after a set amount of time, the system will alert
                                // security
                                licensePlate.ElevatorOccupancy();

                                bool value = licensePlate.ElevatorOccupancy();

                                if (value == true)
                                {
                                    // then there is somebody there, and security will be called
                                    // maybe adding a silent timer so they will have time to leave
                                }
                                else
                                {
                                    // now there is no occupancy, and it will go back to normal
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
