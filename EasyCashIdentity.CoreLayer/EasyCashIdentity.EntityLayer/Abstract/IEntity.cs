﻿namespace EasyCashIdentity.CoreLayer.EasyCashIdentity.EntityLayer.Abstract
{
	public interface IEntity
	{
		public int Id { get; set; }
		public bool Status { get; set; }
	}
}