﻿using System;

namespace behaviac
{
	// Token: 0x020026E4 RID: 9956
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_MageGirl_Mishushi_Action_node29 : Condition
	{
		// Token: 0x0601370B RID: 79627 RVA: 0x005C9C1F File Offset: 0x005C801F
		public Condition_bt_AutoFight_AutoFight_MageGirl_Mishushi_Action_node29()
		{
			this.opl_p0 = 2006;
		}

		// Token: 0x0601370C RID: 79628 RVA: 0x005C9C34 File Offset: 0x005C8034
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D162 RID: 53602
		private int opl_p0;
	}
}
