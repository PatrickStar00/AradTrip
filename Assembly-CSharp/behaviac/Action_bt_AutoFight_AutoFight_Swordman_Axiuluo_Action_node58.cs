﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x020028C7 RID: 10439
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Swordman_Axiuluo_Action_node58 : Action
	{
		// Token: 0x06013AC8 RID: 80584 RVA: 0x005DFBB0 File Offset: 0x005DDFB0
		public Action_bt_AutoFight_AutoFight_Swordman_Axiuluo_Action_node58()
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
			item.skillID = 1700;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06013AC9 RID: 80585 RVA: 0x005DFC40 File Offset: 0x005DE040
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D527 RID: 54567
		private List<Input> method_p0;

		// Token: 0x0400D528 RID: 54568
		private bool method_p1;
	}
}
