﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02002A2B RID: 10795
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Guanka_apc_Cimeiguifeiyan_node19 : Action
	{
		// Token: 0x06013D84 RID: 81284 RVA: 0x005F1758 File Offset: 0x005EFB58
		public Action_bt_Guanka_apc_Cimeiguifeiyan_node19()
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
			item.skillID = 2517;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06013D85 RID: 81285 RVA: 0x005F17E8 File Offset: 0x005EFBE8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D7F2 RID: 55282
		private List<Input> method_p0;

		// Token: 0x0400D7F3 RID: 55283
		private bool method_p1;
	}
}
