﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02003C24 RID: 15396
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_Tuanben_hard_KexilaMeimeng_Boss_ACTION_hard_node15 : Action
	{
		// Token: 0x06015FF3 RID: 90099 RVA: 0x006A5488 File Offset: 0x006A3888
		public Action_bt_Monster_AI_Tuanben_hard_KexilaMeimeng_Boss_ACTION_hard_node15()
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
			item.skillID = 21067;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06015FF4 RID: 90100 RVA: 0x006A5518 File Offset: 0x006A3918
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F874 RID: 63604
		private List<Input> method_p0;

		// Token: 0x0400F875 RID: 63605
		private bool method_p1;
	}
}
