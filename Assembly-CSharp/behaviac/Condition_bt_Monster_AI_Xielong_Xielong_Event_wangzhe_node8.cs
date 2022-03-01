﻿using System;

namespace behaviac
{
	// Token: 0x02003E53 RID: 15955
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Xielong_Xielong_Event_wangzhe_node8 : Condition
	{
		// Token: 0x0601642A RID: 91178 RVA: 0x006BB07E File Offset: 0x006B947E
		public Condition_bt_Monster_AI_Xielong_Xielong_Event_wangzhe_node8()
		{
			this.opl_p0 = HMType.HP_PERCENT;
			this.opl_p1 = BE_Operation.LessThan;
			this.opl_p2 = 0.5f;
		}

		// Token: 0x0601642B RID: 91179 RVA: 0x006BB0A0 File Offset: 0x006B94A0
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHPMP(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FC77 RID: 64631
		private HMType opl_p0;

		// Token: 0x0400FC78 RID: 64632
		private BE_Operation opl_p1;

		// Token: 0x0400FC79 RID: 64633
		private float opl_p2;
	}
}
