﻿using System;

namespace behaviac
{
	// Token: 0x02003FC1 RID: 16321
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_zhaohuanshi_zhaohuanshi_Gebulin_DestinationSelect_node9 : Condition
	{
		// Token: 0x060166EB RID: 91883 RVA: 0x006C9AA3 File Offset: 0x006C7EA3
		public Condition_bt_Monster_AI_zhaohuanshi_zhaohuanshi_Gebulin_DestinationSelect_node9()
		{
			this.opl_p0 = 0.6f;
		}

		// Token: 0x060166EC RID: 91884 RVA: 0x006C9AB8 File Offset: 0x006C7EB8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_GetRandom(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FF3D RID: 65341
		private float opl_p0;
	}
}
