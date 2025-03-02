using System;
using System.Text.RegularExpressions;

// [REF]
//  _: �X�֔ԍ��������������`�F�b�N���� https://soft-rime.com/post-9691/

namespace APIGateway.ZipCode {

    public static class ZipCodeUtils {

        public static bool IsValidZipCode(string zipCode) {
            string pattern = @"^\d{3}-?\d{4}$";
            return Regex.IsMatch(zipCode, pattern);
        }
    }
}
