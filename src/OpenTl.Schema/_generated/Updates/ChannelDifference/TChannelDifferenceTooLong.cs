﻿// ReSharper disable All

namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x410dee07)]
	public class TChannelDifferenceTooLong : IChannelDifference
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Final {get; set;}

       [SerializationOrder(2)]
       public int Pts {get; set;}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 1)]
       public int Timeout {get; set;}

       [SerializationOrder(4)]
       public int TopMessage {get; set;}

       [SerializationOrder(5)]
       public int ReadInboxMaxId {get; set;}

       [SerializationOrder(6)]
       public int ReadOutboxMaxId {get; set;}

       [SerializationOrder(7)]
       public int UnreadCount {get; set;}

       [SerializationOrder(8)]
       public TVector<IMessage> Messages {get; set;}

       [SerializationOrder(9)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(10)]
       public TVector<IUser> Users {get; set;}

	}
}
