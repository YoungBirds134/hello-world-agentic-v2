import React from 'react';

/**
 * Thành phần hiển thị thông tin người dùng
 * Tuân thủ camelCase cho props và functions
 */
interface UserProps {
    userId: number;
    userName: string;
}

export const UserCard: React.FC<UserProps> = ({ userId, userName }) => {
    const handleUserClick = (id: number) => {
        console.log(`User selected: ${id}`);
    };

    return (
        <div className="user-card" onClick={() => handleUserClick(userId)}>
            <h3>{userName}</h3>
            <p>ID: {userId}</p>
        </div>
    );
};
