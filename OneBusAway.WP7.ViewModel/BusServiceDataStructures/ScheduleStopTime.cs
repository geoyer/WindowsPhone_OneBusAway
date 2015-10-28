﻿/* Copyright 2013 Shawn Henry, Rob Smith, and Michael Friedman
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Runtime.Serialization;

namespace OneBusAway.WP7.ViewModel.BusServiceDataStructures
{
    [DataContract()]
    public class ScheduleStopTime
    {
        [DataMember()]
        public DateTime arrivalTime { get; set; }

        [DataMember()]
        public DateTime departureTime { get; set ;}

        [DataMember()]
        public string serviceId { get; set; }

        [DataMember()]
        public string tripId { get; set; }
    }
}
