﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x020025D4 RID: 9684
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Gunman_Danyao_Action_node14 : Action
	{
		// Token: 0x060134EF RID: 79087 RVA: 0x005BD5F4 File Offset: 0x005BB9F4
		public Action_bt_AutoFight_AutoFight_Gunman_Danyao_Action_node14()
		{
			this.m_resultOption = EBTStatus.BT_SUCCESS;
			this.method_p0 = new List<Input>();
			this.method_p0.Capacity = 1;
			Input item = default(Input);
			item.delay = 0;
			item.moveInSkillState = false;
			item.moveKeepDistance = 0;
			item.PKRobotComboCheck = false;
			item.pressTime = 0;
			item.randomChangeDirection = false;
			item.skillID = 1302;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x060134F0 RID: 79088 RVA: 0x005BD684 File Offset: 0x005BBA84
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400CF33 RID: 53043
		private List<Input> method_p0;

		// Token: 0x0400CF34 RID: 53044
		private bool method_p1;
	}
}
