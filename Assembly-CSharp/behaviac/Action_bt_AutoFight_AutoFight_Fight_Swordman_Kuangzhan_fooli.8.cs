﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02002359 RID: 9049
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node51 : Action
	{
		// Token: 0x0601301F RID: 77855 RVA: 0x0059EEB0 File Offset: 0x0059D2B0
		public Action_bt_AutoFight_AutoFight_Fight_Swordman_Kuangzhan_foolish_Action_node51()
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
			item.skillID = 1607;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06013020 RID: 77856 RVA: 0x0059EF40 File Offset: 0x0059D340
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400CA36 RID: 51766
		private List<Input> method_p0;

		// Token: 0x0400CA37 RID: 51767
		private bool method_p1;
	}
}
