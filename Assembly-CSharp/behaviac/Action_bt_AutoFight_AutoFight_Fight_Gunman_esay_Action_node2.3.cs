﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x020020CD RID: 8397
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Fight_Gunman_esay_Action_node25 : Action
	{
		// Token: 0x06012B30 RID: 76592 RVA: 0x0057DA74 File Offset: 0x0057BE74
		public Action_bt_AutoFight_AutoFight_Fight_Gunman_esay_Action_node25()
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
			item.skillID = 1204;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06012B31 RID: 76593 RVA: 0x0057DB04 File Offset: 0x0057BF04
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C523 RID: 50467
		private List<Input> method_p0;

		// Token: 0x0400C524 RID: 50468
		private bool method_p1;
	}
}
