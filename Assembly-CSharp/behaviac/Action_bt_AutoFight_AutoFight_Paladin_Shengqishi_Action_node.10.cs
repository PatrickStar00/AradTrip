﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x0200283A RID: 10298
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Paladin_Shengqishi_Action_node44 : Action
	{
		// Token: 0x060139B2 RID: 80306 RVA: 0x005D9528 File Offset: 0x005D7928
		public Action_bt_AutoFight_AutoFight_Paladin_Shengqishi_Action_node44()
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
			item.skillID = 3717;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x060139B3 RID: 80307 RVA: 0x005D95B8 File Offset: 0x005D79B8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D40A RID: 54282
		private List<Input> method_p0;

		// Token: 0x0400D40B RID: 54283
		private bool method_p1;
	}
}
