﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x020028A8 RID: 10408
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Swordman_Axiuluo_Action_node33 : Action
	{
		// Token: 0x06013A8A RID: 80522 RVA: 0x005DEDF4 File Offset: 0x005DD1F4
		public Action_bt_AutoFight_AutoFight_Swordman_Axiuluo_Action_node33()
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
			item.skillID = 1707;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06013A8B RID: 80523 RVA: 0x005DEE84 File Offset: 0x005DD284
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D4E6 RID: 54502
		private List<Input> method_p0;

		// Token: 0x0400D4E7 RID: 54503
		private bool method_p1;
	}
}
