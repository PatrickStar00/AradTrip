﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02003FA0 RID: 16288
	[GeneratedTypeMetaInfo]
	internal class Action_bt_Monster_AI_zhaohuanshi_zhaohuanshi_Gebulin_Action_node28 : Action
	{
		// Token: 0x060166AA RID: 91818 RVA: 0x006C7E70 File Offset: 0x006C6270
		public Action_bt_Monster_AI_zhaohuanshi_zhaohuanshi_Gebulin_Action_node28()
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
			item.skillID = 5112;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x060166AB RID: 91819 RVA: 0x006C7F00 File Offset: 0x006C6300
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FEFD RID: 65277
		private List<Input> method_p0;

		// Token: 0x0400FEFE RID: 65278
		private bool method_p1;
	}
}
