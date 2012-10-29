/* $Id: MamdaOrderBookRecap.cs,v 1.1.40.5 2012/08/24 16:12:13 clintonmcdowell Exp $
 *
 * OpenMAMA: The open middleware agnostic messaging API
 * Copyright (C) 2011 NYSE Technologies, Inc.
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA
 * 02110-1301 USA
 */

using System;

namespace Wombat
{
	/// <summary>
	/// MamdaOrderBookRecap is an interface that provides access to order
	/// book related fields.
	/// </summary>
	public interface MamdaOrderBookRecap : MamdaBasicEvent
	{
		/// <summary>
		/// Returns a reference to the full orderbook if a full book is being
		/// maintained by the MamdaOrderBookListener.
		/// </summary>
		/// <returns></returns>
		MamdaOrderBook getFullOrderBook ();
	}
}