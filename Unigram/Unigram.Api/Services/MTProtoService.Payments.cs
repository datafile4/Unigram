﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.TL;
using Telegram.Api.TL.Methods.Payments;

namespace Telegram.Api.Services
{
    public partial class MTProtoService
    {
        public void ClearSavedInfoAsync(bool info, bool credentials, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new TLPaymentsClearSavedInfo { IsInfo = info, IsCredentials = credentials };

            const string caption = "payments.clearSavedInfo";
            SendInformativeMessage(caption, obj, callback, faultCallback);
        }

        public void GetPaymentFormAsync(int msgId, Action<TLPaymentsPaymentForm> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new TLPaymentsGetPaymentForm { MsgId = msgId };

            const string caption = "payments.getPaymentForm";
            SendInformativeMessage(caption, obj, callback, faultCallback);
        }

        public void GetPaymentReceiptAsync(int msgId, Action<TLPaymentsPaymentReceipt> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new TLPaymentsGetPaymentReceipt { MsgId = msgId };

            const string caption = "payments.getPaymentReceipt";
            SendInformativeMessage(caption, obj, callback, faultCallback);
        }

        public void GetSavedInfoAsync(Action<TLPaymentsSavedInfo> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new TLPaymentsGetSavedInfo { };

            const string caption = "payments.getSavedInfo";
            SendInformativeMessage(caption, obj, callback, faultCallback);
        }

        // TODO: public void SendPaymentFormCallback()
        // TODO: public void ValidateRequestedInfo()
    }
}