﻿using System;

namespace behaviac
{
	// Token: 0x02001EF3 RID: 7923
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Fightergirl_qigong_Action_node7 : Condition
	{
		// Token: 0x0601278A RID: 75658 RVA: 0x00567A9F File Offset: 0x00565E9F
		public Condition_bt_AutoFight_AutoFight_Fightergirl_qigong_Action_node7()
		{
			this.opl_p0 = 3100;
		}

		// Token: 0x0601278B RID: 75659 RVA: 0x00567AB4 File Offset: 0x00565EB4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C17F RID: 49535
		private int opl_p0;
	}
}
