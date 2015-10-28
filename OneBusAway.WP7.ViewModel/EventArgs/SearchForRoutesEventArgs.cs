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
using System.Collections.Generic;
using OneBusAway.WP7.ViewModel.BusServiceDataStructures;
using System.Device.Location;

namespace OneBusAway.WP7.ViewModel.EventArgs
{
    public class SearchForRoutesEventArgs : AModelEventArgs
    {
        public List<Route> routes { get; private set; }
        public GeoCoordinate location { get; private set; }
        public string query { get; private set; }

        public SearchForRoutesEventArgs(List<Route> routes, GeoCoordinate location, string query, Exception error)
            : base(error)
        {
            this.routes = routes;
            this.query = query;
            this.location = location;
        }
    }
}
