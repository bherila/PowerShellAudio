﻿/*
 * Copyright © 2014 Jeremy Herbison
 * 
 * This file is part of PowerShell Audio.
 * 
 * PowerShell Audio is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser
 * General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your
 * option) any later version.
 * 
 * PowerShell Audio is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the
 * implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License
 * for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public License along with PowerShell Audio.  If not, see
 * <http://www.gnu.org/licenses/>.
 */

#pragma warning disable 0649

namespace PowerShellAudio.Extensions.Apple
{
    struct AudioStreamBasicDescription
    {
        internal double SampleRate;

        internal AudioFormat AudioFormat;

        internal AudioFormatFlags Flags;

        internal uint BytesPerPacket;

        internal uint FramesPerPacket;

        internal uint BytesPerFrame;

        internal uint ChannelsPerFrame;

        internal uint BitsPerChannel;

        internal uint Reserved;
    }
}

#pragma warning restore 0649