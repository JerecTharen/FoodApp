//
//  User.swift
//  Foodii
//
//  Created by Tyler Donohue on 5/4/19.
//  Copyright © 2019 Tyler Donohue. All rights reserved.
//

import Foundation


protocol Identifiable {
    var id: String? { get set }
}

protocol DocumentUserSerializable {
    init?(humanDictionary: [String: Any])
}
// uid, first, last, email, password, profilePic, addedRecipiController, savedREcipiController, friends, 

struct Users {
    var id: String
    var firstName: String
    var lastName: String
    var email: String
    var password: String
    var profilePic: String
    var addedRecipi: String
    var savedRecipi: String
    
    var humanDictionary: [String: Any] {
        return [
            "id": id,
            "firstName": firstName,
            "lastName": lastName,
            "email": email,
            "password": password,
            "profilePic": profilePic,
            "addedRecipi": addedRecipi,
            "savedRecipi": savedRecipi
            
        ]
    }
}

extension Users {
    init?(humanDictionary: [String: Any]) {
        <#statements#>
    }
}
